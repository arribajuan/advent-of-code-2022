using AOC2022.Day1.CalorieCounter;

namespace AOC2022.Day1.CalorieCounter.Tests;

public class ElfCalorieCounterTest
{
    [Fact]
    public void TextFileIsLoaded()
    {
        ElfCalorieCounter ecc = new ElfCalorieCounter();
        List<string> sampleData = GetSampleData();

        Assert.NotEmpty(sampleData);
    }

    [Fact]
    public void TextFileHas14Rows()
    {
        ElfCalorieCounter ecc = new ElfCalorieCounter();
        List<string> sampleData = GetSampleData();

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
        List<string> sampleData = GetSampleData();

        Assert.True(expectedValue == sampleData[inputPosition], $"Expected '{expectedValue}' at position {inputPosition}, got '{sampleData[inputPosition]}'");
    }

    [Theory]
    [InlineData(0, 6000)]
    [InlineData(1, 4000)]
    [InlineData(2, 11000)]
    [InlineData(3, 24000)]
    [InlineData(4, 10000)]
    public void CountCaloriesPerElfYieldsSpecificCalorieTotals(int elfPosition, int expectedTotalCalories)
    {
        List<int> calorieTotals = GetCalorieTotals();

        Assert.True(expectedTotalCalories == calorieTotals[elfPosition], $"Expected '{expectedTotalCalories}' at position {elfPosition}, got '{calorieTotals[elfPosition]}'");
    }

    private List<string> GetSampleData()
    {
        string sampleDataPath = Environment.CurrentDirectory + "/assets/data/sample-data.txt";

        ElfCalorieCounter ecc = new ElfCalorieCounter();
        List<string> sampleData = ecc.LoadInput(sampleDataPath);

        return sampleData;
    }

    private List<int> GetCalorieTotals()
    {
        List<string> sampleData = GetSampleData();

        ElfCalorieCounter ecc = new ElfCalorieCounter();
        List<int> calorieTotals = ecc.CountCaloriesPerElf(sampleData);

        return calorieTotals;
    }
}