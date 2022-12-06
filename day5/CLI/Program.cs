using System.Diagnostics;
using System.IO;

using AOC2022.Day5.SupplyStack;


string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";
List<string> inputData = FileLoader.LoadInput(inputDataPath);

int separatorLineIndex = 9;

List<string> suppliesStrings = inputData.GetRange(0, separatorLineIndex);
List<string> instructionsStrings = inputData.GetRange(separatorLineIndex + 1, inputData.Count - separatorLineIndex - 1);


CargoShip ship = new CargoShip(suppliesStrings.ToArray(), true);
string[] instructions = instructionsStrings.ToArray();

foreach (string instruction in instructions)
{
    CraneInstruction ci = new CraneInstruction(instruction);
    ship.MoveCrates(ci);
}


// Works in terminal
Console.WriteLine("Advent of code - Day 5 - console");
Console.WriteLine("");
Console.WriteLine($"Top of the stack: {ship.TopOfTheStacksString}");
Console.WriteLine("");