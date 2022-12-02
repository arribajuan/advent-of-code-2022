using AOC2022.Day1.CalorieCounter;

namespace AOC2022.Day1.CalorieCounter.Tests;

public class TextFileTest
{
    [Fact]
    public void TextFileIsLoaded()
    {
        ElfCalorieCounter ecc = new ElfCalorieCounter();
        List<string> sampleData = Helper.GetSampleData();

        Assert.NotEmpty(sampleData);
    }

    [Fact]
    public void TextFileHas14Rows()
    {
        ElfCalorieCounter ecc = new ElfCalorieCounter();
        List<string> sampleData = Helper.GetSampleData();

        Assert.Equal(14, sampleData.Count);
    }

    [Theory]
    [InlineData(0, "1000")]
    [InlineData(4, "4000")]
    [InlineData(5, "")]
    [InlineData(13, "10000")]
    public void TextFileHasSpecificData(int inputPosition, string expectedValue)
    {
        ElfCalorieCounter ecc = new ElfCalorieCounter();
        List<string> sampleData = Helper.GetSampleData();

        Assert.True(expectedValue == sampleData[inputPosition], $"Expected '{expectedValue}' at position {inputPosition}, got '{sampleData[inputPosition]}'");
    }
}


