using AOC2022.Day7.SpaceOnDevice;

string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "sample-data.txt";
List<string> inputData = FileLoader.LoadInput(inputDataPath);

Storage s = new Storage(inputData);


// Works in terminal
Console.WriteLine("Advent of code - Day 7 - console");
Console.WriteLine("");

Console.WriteLine("Input");
foreach (string inputLine in inputData)
{
    Console.WriteLine($" - {inputLine}");
}


