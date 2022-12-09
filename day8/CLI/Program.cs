using System.Diagnostics;
using System.IO;

using AOC2022.Day8.Treetop;

string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";
int[,] inputMatrix = FileLoader.LoadInput(inputDataPath);

TreetopAnalyser ta = new TreetopAnalyser(inputMatrix);

Console.WriteLine("Advent of code - Day 8 - console");
Console.WriteLine("");
Console.WriteLine($"Total visible trees: {ta.TotalVisibleTrees}");
Console.WriteLine("");

System.Diagnostics.Debug.WriteLine("Advent of code - Day 8 - debug");
System.Diagnostics.Debug.WriteLine("");
System.Diagnostics.Debug.WriteLine($"Total visible trees: {ta.TotalVisibleTrees}");
System.Diagnostics.Debug.WriteLine("");
