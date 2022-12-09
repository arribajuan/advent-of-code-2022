using System.Diagnostics;
using System.IO;

using AOC2022.Day9.Ropebridge;

string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";
List<MotionInRope> inputMotionInRope = FileLoader.LoadInput(inputDataPath);

PositionInRope initialPosition = new PositionInRope() { X = 0, Y = 0 };
RopePhysicsSimulator sim = new RopePhysicsSimulator(initialPosition, inputMotionInRope);

Console.WriteLine("Advent of code - Day 8 - console");
Console.WriteLine($"Unique locations visited by the tail: {sim.TailUniqueLocationsVisited}");

Debug.WriteLine("Advent of code - Day 8 - debug");
Debug.WriteLine($"Unique locations visited by the tail: {sim.TailUniqueLocationsVisited}");