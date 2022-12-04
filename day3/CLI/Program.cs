using System.Diagnostics;
using System.IO;

using AOC2022.Day3.Rucksack;


string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";

List<string> inputData = FileLoader.LoadInput(inputDataPath);

int costSum = 0;
foreach (string sampleItem in inputData)
{
    ElfRucksack rs = new ElfRucksack(sampleItem);
    costSum += rs.MisplacedItemCost;
}

// Works in terminal
Console.WriteLine("Advent of code - Day 3 - console");
Console.WriteLine("");
Console.WriteLine($"Total misplaced item cost: {costSum}");
Console.WriteLine("");

// Works in VS
System.Diagnostics.Debug.WriteLine("Advent of code - Day 3 - debug");
System.Diagnostics.Debug.WriteLine("");
System.Diagnostics.Debug.WriteLine($"Total misplaced item cost: {costSum}");
System.Diagnostics.Debug.WriteLine("");
