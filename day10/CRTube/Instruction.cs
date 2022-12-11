namespace AOC2022.Day10.CRTube;

public class Instruction
{
    public string Name { get; set;  }
    public int? Value { get; set;  }

    public Instruction()
    {
        Name = "noop";
    }
}