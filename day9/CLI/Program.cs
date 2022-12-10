using AOC2022.Day9.Ropebridge;

var inputPath = AppDomain.CurrentDomain.BaseDirectory;
var input = FileLoader.LoadInput(inputPath + "input-data.txt");
var inputSample1 = FileLoader.LoadInput(inputPath + "sample1-data.txt");
var inputSample2 = FileLoader.LoadInput(inputPath + "sample2-data.txt");

var initialPosition = new RopeKnot { X = 0, Y = 0 };
var ropeSim1_sample1_2= new RopeSimulator1(initialPosition, inputSample1);
var ropeSim2_sample1_2= new RopeSimulator2(initialPosition, inputSample1, 2);
var ropeSim2_sample2_10 = new RopeSimulator2(initialPosition, inputSample2, 10);
var ropeSim1_2 = new RopeSimulator1(initialPosition, input);
var ropeSim2_2 = new RopeSimulator2(initialPosition, input, 2);
var ropeSim2_10 = new RopeSimulator2(initialPosition, input, 10);

Console.WriteLine("Advent of code - Day 9 - console");
Console.WriteLine("");
Console.WriteLine($"Sim1 with 2 knots - unique locations visited by the tail: {ropeSim1_sample1_2.TailUniqueLocationsVisited} (sample 1)");
Console.WriteLine($"Sim2 with 2 knots - unique locations visited by the tail: {ropeSim2_sample1_2.TailUniqueLocationsVisited} (sample 1)");
Console.WriteLine($"Sim2 with 10 knots - unique locations visited by the tail: {ropeSim2_sample2_10.TailUniqueLocationsVisited} (sample 2)");
Console.WriteLine("");
Console.WriteLine($"Sim1 with 2 knots - unique locations visited by the tail: {ropeSim1_2.TailUniqueLocationsVisited} (star 1)");
Console.WriteLine($"Sim2 with 2 knots - unique locations visited by the tail: {ropeSim2_2.TailUniqueLocationsVisited} (star 1)");
Console.WriteLine($"Sim2 with 10 knots - unique locations visited by the tail: {ropeSim2_10.TailUniqueLocationsVisited} (star 2)");
Console.WriteLine("");
