using AOC2022.Day7.SpaceOnDevice;

string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";
List<string> inputData = FileLoader.LoadInput(inputDataPath);

Storage s = new Storage(inputData);

long usedSpace = s.rootDirectory.TotalBranchSize;
long totalSpace = 70000000;
long updateSpace = 30000000;
long spaceToDelete = usedSpace - updateSpace;

// Works in terminal
Console.WriteLine("Advent of code - Day 7 - console");
Console.WriteLine("");
Console.WriteLine($"Total used space = {usedSpace}");
Console.WriteLine($"Space to delete = {spaceToDelete}");
Console.WriteLine("");

long star1Total = s.Star1Calculation(100000, s.rootDirectory);
Console.WriteLine($"Star 1 total = {star1Total}");
Console.WriteLine("");

long star2Total = 0;
s.Star2Calculation(spaceToDelete, s.rootDirectory, ref star2Total);
Console.WriteLine($"Star 2 total = {star2Total}");
Console.WriteLine("");
