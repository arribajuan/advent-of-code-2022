namespace AOC2022.Day10.CRTube;

public class LogItem
{
    public int Cycle { get; set; }
    public int RegisterX { get; set; }
    public string InstructionName { get; set; }
    public int InstructionValue { get; set; }

    public int SignalStrength => CalculateSignalStrength();

    public LogItem()
    {
        Cycle = 0;
        RegisterX = 0;
        InstructionName = String.Empty;
        InstructionValue = 0;
    }

    public override string ToString()
    {
        string result = "";
        if (InstructionName == "noop")
        {
            result = $"{Cycle} - RegisterX = {RegisterX} - {InstructionName} - Signal strength = {SignalStrength}";
        }
        else if (InstructionName == "addx")
        {
            result = $"{Cycle} - RegisterX = {RegisterX} - {InstructionName} {InstructionValue} - Signal strength = {SignalStrength}";
        }

        return result;
    }

    private int CalculateSignalStrength()
    {
        return Cycle * RegisterX;
    }
}