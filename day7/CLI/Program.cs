using AOC2022.Day7.SpaceOnDevice;

string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";
List<string> inputData = FileLoader.LoadInput(inputDataPath);

Storage s = new Storage(inputData);


// Works in terminal
Console.WriteLine("Advent of code - Day 7 - console");
Console.WriteLine("");

long star1Total = s.Star1Calculation(100000, s.rootDirectory);
Console.WriteLine($"Star 1 total = {star1Total}");
Console.WriteLine("");