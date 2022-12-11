namespace AOC2022.Day10.CRTube;

public class CPU
{
    public int CPUCycleCount { get; set; }

    public int RegisterX { get; set; }

    public List<LogItem> Log { get; set; }
    
    public CPU(int initialXValue)
    {
        CPUCycleCount = 0;
        RegisterX = initialXValue;
        Log = new List<LogItem>();
    }

    public void ProcessInstructions(List<Instruction> instructionList)
    {
        int cpuCycles = 0;
        int newXValue = RegisterX;
        int instructionValue = 0;
        
        foreach (Instruction cpuInstruction in instructionList)
        {
            #region Prepare cpu instruction
            
            if (cpuInstruction.Name == "noop")
            {
                cpuCycles = 1;
            }
            else if (cpuInstruction.Name == "addx")
            {
                cpuCycles = 2;
                instructionValue = Convert.ToInt32((cpuInstruction.Value));
                newXValue = RegisterX + instructionValue;
            }
            
            #endregion
            
            #region Execute and log
            
            for (int i = 0; i <= cpuCycles; i++)
            {
                if (i == cpuCycles)
                {
                    RegisterX = newXValue;
                }
                else
                {
                    CPUCycleCount++;

                    Log.Add(new LogItem()
                    {
                        Cycle = CPUCycleCount,
                        InstructionName = cpuInstruction.Name,
                        InstructionValue = instructionValue,
                        RegisterX = RegisterX
                    });
                }
            }
            
            #endregion
        }
    }
}