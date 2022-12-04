using System.Diagnostics;
using System.IO;

using AOC2022.Day4.CampCleanup;

string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";
List<string> inputData = FileLoader.LoadInput(inputDataPath);

int overlapCount = 0;
foreach (string inputAssignmentString in inputData)
{
    ElfPair ep = new ElfPair(inputAssignmentString);
    if (ep.AreAssignmentsOverlapping)
    {
        overlapCount++;
    }
}

// Works in terminal
Console.WriteLine("Advent of code - Day 4 - console");
Console.WriteLine("");
Console.WriteLine($"Total assignment overlap: {overlapCount}");
Console.WriteLine("");

// Works in VS
System.Diagnostics.Debug.WriteLine("Advent of code - Day 4 - debug");
System.Diagnostics.Debug.WriteLine("");
System.Diagnostics.Debug.WriteLine($"Total assignment overlap: {overlapCount}");
System.Diagnostics.Debug.WriteLine("");