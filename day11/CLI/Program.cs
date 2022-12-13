using AOC2022.Day11.MITM;

var inputPath = AppDomain.CurrentDomain.BaseDirectory;
var inputData = FileLoader.LoadInput(inputPath + "input-data.txt");
var sampleData= FileLoader.LoadInput(inputPath + "sample-data.txt");

Simulator sim = new Simulator(inputData);
sim.PlayRounds(10000);

Console.WriteLine("Advent of code - Day 11 - console");
Console.WriteLine($" - Total monkey business = {sim.TotalMonkeyBusiness}");
foreach (Monkey monkey in sim.Monkeys)
{
    Console.WriteLine($"    - Monkey {monkey.MonkeyNumber} had {monkey.Interactions} interactions");    
}

/*
== After round 1 ==
Monkey 0 inspected items 2 times.
Monkey 1 inspected items 4 times.
Monkey 2 inspected items 3 times.
Monkey 3 inspected items 6 times.

== After round 20 ==
Monkey 0 inspected items 99 times.
Monkey 1 inspected items 97 times.
Monkey 2 inspected items 8 times.
Monkey 3 inspected items 103 times.

== After round 1000 ==
Monkey 0 inspected items 5204 times.
Monkey 1 inspected items 4792 times.
Monkey 2 inspected items 199 times.
Monkey 3 inspected items 5192 times.
*/