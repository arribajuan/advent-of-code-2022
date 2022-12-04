using System.Diagnostics;
using System.IO;

using AOC2022.Day4.CampCleanup;

string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";
List<string> inputData = FileLoader.LoadInput(inputDataPath);

int fullOverlapCount = 0;
int partialOverlapCount = 0;
foreach (string inputAssignmentString in inputData)
{
    ElfPair ep = new ElfPair(inputAssignmentString);
    if (ep.AreAssignmentsFullyOverlapping)
    {
        fullOverlapCount++;
    }
    if (ep.AreAssignmentsPartiallyOverlapping)
    {
        partialOverlapCount++;
    }
}
int someOverlap = fullOverlapCount + partialOverlapCount;
int noOverlapCount = inputData.Count - someOverlap;

// Works in terminal
Console.WriteLine("Advent of code - Day 4 - console");
Console.WriteLine("");
Console.WriteLine($"Full assignment overlap: {fullOverlapCount}");
Console.WriteLine($"Partial assignment overlap: {partialOverlapCount}");
Console.WriteLine($"Some assignment overlap: {someOverlap}");
Console.WriteLine($"No overlap: {noOverlapCount}");
Console.WriteLine($"Total assignments: {inputData.Count}");
Console.WriteLine("");

// Works in VS
System.Diagnostics.Debug.WriteLine("Advent of code - Day 4 - debug");
System.Diagnostics.Debug.WriteLine("");
System.Diagnostics.Debug.WriteLine($"Full assignment overlap: {fullOverlapCount}");
System.Diagnostics.Debug.WriteLine($"Partial assignment overlap: {partialOverlapCount}");
System.Diagnostics.Debug.WriteLine($"Some assignment overlap: {someOverlap}");
System.Diagnostics.Debug.WriteLine($"No overlap: {noOverlapCount}");
System.Diagnostics.Debug.WriteLine($"Total assignments: {inputData.Count}");
System.Diagnostics.Debug.WriteLine("");