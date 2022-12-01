using AOC2022.Day1.CalorieCounter;

namespace AOC2022.Day1.CalorieCounter.Tests;

public class ElfCalorieCounterTest
{
    private ElfCalorieCounter ecc;
    private string sampleDataPath = string.Empty;
    private List<string> sampleData;
    

    public ElfCalorieCounterTest()
    {
        this.ecc = new ElfCalorieCounter();

        this.sampleDataPath = Environment.CurrentDirectory + "/assets/data/sample-data.txt";
        this.sampleData = ecc.LoadInput(this.sampleDataPath);
    }

    [Fact]
    public void TextFileIsLoaded()
    {
        Assert.NotEmpty(this.sampleData);
    }

    [Fact]
    public void TextFileHas14Rows()
    {
        Assert.Equal(14, this.sampleData.Count);
    }

    [Theory]
    [InlineData(0, "1000")]
    [InlineData(4, "4000")]
    [InlineData(5, "")]
    [InlineData(13, "10000")]
    public void TextFileHasSpecificData(int inputPosition, string expectedValue)
    {
        Assert.True(expectedValue == this.sampleData[inputPosition], $"Expected '{expectedValue}' at position {inputPosition}, got '{this.sampleData[inputPosition]}'");
    }

}