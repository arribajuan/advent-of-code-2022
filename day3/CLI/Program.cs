using System.Diagnostics;
using System.IO;

using AOC2022.Day3.Rucksack;

string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";
List<string> inputData = FileLoader.LoadInput(inputDataPath);

ElfGroup elfGroup = new ElfGroup();
foreach (string inputItem in inputData)
{
    elfGroup.AddRucksack(new ElfRucksack(inputItem));
}

// Works in terminal
Console.WriteLine("Advent of code - Day 3 - console");
Console.WriteLine("");
Console.WriteLine($"Total misplaced item cost: {elfGroup.MisplacedItemTotalCost}");
Console.WriteLine($"Total common item cost: {elfGroup.CommonItemTotalCost}");
Console.WriteLine("");

// Works in VS
System.Diagnostics.Debug.WriteLine("Advent of code - Day 3 - debug");
System.Diagnostics.Debug.WriteLine("");
System.Diagnostics.Debug.WriteLine($"Total misplaced item cost: {elfGroup.MisplacedItemTotalCost}");
System.Diagnostics.Debug.WriteLine($"Total common item cost: {elfGroup.CommonItemTotalCost}");
System.Diagnostics.Debug.WriteLine("");