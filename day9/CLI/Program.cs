using System.Diagnostics;
using AOC2022.Day9.Ropebridge;

var inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";
var inputMotionInRope = FileLoader.LoadInput(inputDataPath);

var initialPosition = new PositionInRope { X = 0, Y = 0 };
var sim = new RopePhysicsSimulator(initialPosition, inputMotionInRope);

Console.WriteLine("Advent of code - Day 8 - console");
Console.WriteLine($"Unique locations visited by the tail: {sim.TailUniqueLocationsVisited}");

Debug.WriteLine("Advent of code - Day 8 - debug");
Debug.WriteLine($"Unique locations visited by the tail: {sim.TailUniqueLocationsVisited}");