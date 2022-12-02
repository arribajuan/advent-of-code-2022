using System.Diagnostics;
using System.IO;

using AOC2022.Day1.CalorieCounter;


string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";

ElfCalorieCounter ecc = new ElfCalorieCounter();
List<string> inputData = ecc.LoadInput(inputDataPath);
List<int> calorieTotals = ecc.CountCaloriesPerElf(inputData);
int caloriesFromTopElf = ecc.FindCaloriesFromTopElf(calorieTotals);
int caloriesFromTopThreeElves = ecc.FindCaloriesFromTopThreeElves(calorieTotals);


// Works in terminal
Console.WriteLine("Advent of code - Day 1 - console");
Console.WriteLine("");
Console.WriteLine($"The elf with the biggest snack has {caloriesFromTopElf} calories in total");
Console.WriteLine($"The 3 elves with the biggest snacks have {caloriesFromTopThreeElves} calories in total");
Console.WriteLine("");

// Works in VS
System.Diagnostics.Debug.WriteLine("Advent of code - Day 1 - debug");
System.Diagnostics.Debug.WriteLine("");
System.Diagnostics.Debug.WriteLine($"The elf with the biggest snack has {caloriesFromTopElf} calories in total");
System.Diagnostics.Debug.WriteLine($"The 3 elves with the biggest snacks have {caloriesFromTopThreeElves} calories in total");
System.Diagnostics.Debug.WriteLine("");
