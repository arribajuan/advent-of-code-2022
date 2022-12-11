using AOC2022.Day10.CRTube;

var inputPath = AppDomain.CurrentDomain.BaseDirectory;
var input = FileLoader.LoadInput(inputPath + "input-data.txt");
var inputSample1 = FileLoader.LoadInput(inputPath + "sample1-data.txt");
var inputSample2 = FileLoader.LoadInput(inputPath + "sample2-data.txt");

CPU cpuInput = new CPU(1);
cpuInput.ProcessInstructions(input);

CPU cpuSample1 = new CPU(1);
cpuSample1.ProcessInstructions(inputSample1);

CPU cpuSample2 = new CPU(1);
cpuSample2.ProcessInstructions(inputSample2);

Console.WriteLine("Advent of code - Day 10 - console");

int cycleOfInterst = 20;
int signalStrengthTotal = 0;
foreach (LogItem logItem in cpuInput.Log)
{
    Console.WriteLine($"{logItem.ToString()}");

    if (logItem.Cycle == cycleOfInterst)
    {
        Console.WriteLine($" - We add this one up {logItem.SignalStrength}");

        cycleOfInterst += 40;
        signalStrengthTotal += logItem.SignalStrength;
    }
}

Console.WriteLine($"");
Console.WriteLine($"Star 1 answer: {signalStrengthTotal}");

