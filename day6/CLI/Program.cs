using System.Diagnostics;
using System.IO;

using AOC2022.Day6.TuningTrouble;

string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";
List<string> inputData = FileLoader.LoadInput(inputDataPath);

ElfDevice device = new ElfDevice(inputData[0]);

// Works in terminal
Console.WriteLine("Advent of code - Day 6 - console");
Console.WriteLine("");
Console.WriteLine($"First marker at: {device.FirstMarkerIndex}");
Console.WriteLine("");

System.Diagnostics.Debug.WriteLine("Advent of code - Day 6 - debug");
System.Diagnostics.Debug.WriteLine("");
System.Diagnostics.Debug.WriteLine($"First marker at: {device.FirstMarkerIndex}");
System.Diagnostics.Debug.WriteLine("");
