using AOC2022.Day1.CalorieCounter;

namespace AOC2022.Day1.CalorieCounter.Tests;

public class ElfCalorieCounterTest
{
    [Theory]
    [InlineData(0, 6000)]
    [InlineData(1, 4000)]
    [InlineData(2, 11000)]
    [InlineData(3, 24000)]
    [InlineData(4, 10000)]
    public void CountCaloriesPerElfYieldsSpecificCalorieTotals(int elfPosition, int expectedTotalCalories)
    {
        List<int> calorieTotals = Helper.GetCalorieTotals();

        Assert.True(expectedTotalCalories == calorieTotals[elfPosition], $"Expected '{expectedTotalCalories}' at position {elfPosition}, got '{calorieTotals[elfPosition]}'");
    }

    [Fact]
    public void TopElfCalorieTotal()
    {
        List<int> calorieTotals = Helper.GetCalorieTotals();

        ElfCalorieCounter ecc = new ElfCalorieCounter();
        int caloriesFromTopElf = ecc.FindCaloriesFromTopElf(calorieTotals);

        Assert.Equal(24000, caloriesFromTopElf);
    }

    [Fact]
    public void TopThreeElvesCalorieTotal()
    {
        List<int> calorieTotals = Helper.GetCalorieTotals();

        ElfCalorieCounter ecc = new ElfCalorieCounter();
        int caloriesFromTopThreeElves = ecc.FindCaloriesFromTopThreeElves(calorieTotals);

        Assert.Equal(45000, caloriesFromTopThreeElves);
    }
}