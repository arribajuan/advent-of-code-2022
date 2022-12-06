using System.Diagnostics;
using System.IO;

using AOC2022.Day6.TuningTrouble;

string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";
List<string> inputData = FileLoader.LoadInput(inputDataPath);

ElfDevice device = new ElfDevice(inputData[0]);

// Works in terminal
Console.WriteLine("Advent of code - Day 6 - console");
Console.WriteLine("");
Console.WriteLine($"First packet marker at: {device.FirstPacketMarkerIndex}");
Console.WriteLine($"First message marker at: {device.FirstMessageMarkerIndex}");
Console.WriteLine("");

System.Diagnostics.Debug.WriteLine("Advent of code - Day 6 - debug");
System.Diagnostics.Debug.WriteLine("");
System.Diagnostics.Debug.WriteLine($"First packet marker at: {device.FirstPacketMarkerIndex}");
System.Diagnostics.Debug.WriteLine($"First message marker at: {device.FirstMessageMarkerIndex}");
System.Diagnostics.Debug.WriteLine("");
