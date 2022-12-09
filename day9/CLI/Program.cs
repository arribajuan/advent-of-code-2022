using System.Diagnostics;
using AOC2022.Day9.Ropebridge;

var inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";
var inputMotionInRope = FileLoader.LoadInput(inputDataPath);

var initialPosition = new RopeKnot { X = 0, Y = 0 };
var ropeSim1 = new RopeSimulator1(initialPosition, inputMotionInRope);
var ropeSim2 = new RopeSimulator2(initialPosition, 10, inputMotionInRope);

Console.WriteLine("Advent of code - Day 9 - console");
Console.WriteLine($"Sim1 - unique locations visited by the tail: {ropeSim1.TailUniqueLocationsVisited}");

Debug.WriteLine("Advent of code - Day 9 - debug");
Debug.WriteLine($"Sim1 - unique locations visited by the tail: {ropeSim1.TailUniqueLocationsVisited}");