using System.Text;
using AOC2022.Day3.Rucksack;

namespace AOC2022.Day3.Rucksack.Tests;

public class RucksackTests
{
    [Theory]
    [InlineData("", "", "")]
    [InlineData("A", "A", "")]
    [InlineData("AB", "A", "B")]
    [InlineData("ABC", "AB", "C")]
    [InlineData("vJrwpWtwJgWrhcsFMMfFFhFp", "vJrwpWtwJgWr", "hcsFMMfFFhFp")]
    [InlineData("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "jqHRNqRjqzjGDLGL", "rsFMfFZSrLrFZsSL")]
    [InlineData("PmmdzqPrVvPwwTWBwg", "PmmdzqPrV", "vPwwTWBwg")]
    public void RucksackSplitsItemsInCompartments(string ruckSackItemString, string expectedCompartment1ItemString, string expectedCompartment2ItemString)
    {
        ElfRucksack rs = new ElfRucksack(ruckSackItemString);

        Assert.Equal(expectedCompartment1ItemString, rs.ItemStringCompartment1);
        Assert.Equal(expectedCompartment2ItemString, rs.ItemStringCompartment2);
    }

    [Theory]
    [InlineData("", "")]
    [InlineData("A", "")]
    [InlineData("AAB", "")]
    [InlineData("ABB", "B")]
    [InlineData("ABBA", "A,B")]
    [InlineData("ABBAC", "A")]
    [InlineData("vJrwpWtwJgWrhcsFMMfFFhFp", "p")]
    [InlineData("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "L")]
    [InlineData("PmmdzqPrVvPwwTWBwg", "P")]
    [InlineData("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", "v")]
    [InlineData("ttgJtRGJQctTZtZT", "t")]
    [InlineData("CrZsJsPPZsGzwwsLwLmpwMDw", "s")]
    public void RucksackFindMisplacedItems(string ruckSackItemString, string expectedMisplacedItemString)
    {
        List<string> expectedMisplacedItemList = new List<string>();
        if (expectedMisplacedItemString.Length > 0)
        {
            expectedMisplacedItemList = expectedMisplacedItemString.Split(',').ToList();
        }

        ElfRucksack rs = new ElfRucksack(ruckSackItemString);

        Assert.Equal(expectedMisplacedItemList, rs.MisplacedItemList);
    }

    [Theory]
    [InlineData("", 0)]
    [InlineData("A", 0)]
    [InlineData("AAB", 0)]
    [InlineData("ABB", 28)]
    [InlineData("ABBA", 55)]
    [InlineData("ABBAC", 27)]
    [InlineData("vJrwpWtwJgWrhcsFMMfFFhFp", 16)]
    [InlineData("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", 38)]
    [InlineData("PmmdzqPrVvPwwTWBwg", 42)]
    [InlineData("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", 22)]
    [InlineData("ttgJtRGJQctTZtZT", 20)]
    [InlineData("CrZsJsPPZsGzwwsLwLmpwMDw", 19)]
    public void RucksackCalculateNisplacedItemCost(string ruckSackItemString, int expectedCost)
    {
        ElfRucksack rs = new ElfRucksack(ruckSackItemString);

        Assert.Equal(expectedCost, rs.MisplacedItemCost);
    }

    [Fact]
    public void RucksackSampleDataTotalCost()
    {
        List<string> sampleData = Helper.GetSampleData();

        ElfGroup elfGroup = new ElfGroup();
        foreach (string sampleItem in sampleData)
        {
            elfGroup.AddRucksack(new ElfRucksack(sampleItem));
        }

        Assert.Equal(157, elfGroup.MisplacedItemTotalCost);
    }
}