using AOC2022.Day11.MITM;

var inputPath = AppDomain.CurrentDomain.BaseDirectory;
var inputData = FileLoader.LoadInput(inputPath + "input-data.txt");
//var sampleData= FileLoader.LoadInput(inputPath + "sample-data.txt");

Simulator sim = new Simulator(inputData);
sim.PlayRounds(20);

Console.WriteLine("Advent of code - Day 11 - console");
Console.WriteLine($" - Star 1 - total monkey business = {sim.TotalMonkeyBusiness}");
