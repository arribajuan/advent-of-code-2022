using System.Text;

namespace AOC2022.Day10.CRTube;

public class FileLoader
{
    public static List<Instruction> LoadInput(string inputFilePath)
    {
        var result = new List<Instruction>();

        var fileLines = File.ReadAllLines(inputFilePath, Encoding.Default);
        foreach (var fileLine in fileLines)
        {
            string[] subStrings = fileLine.Split(" ");
            string instructionName = subStrings[0];
            int? instructionValue = null;
            if (subStrings.Length > 1)
            {
                instructionValue = Convert.ToInt32(subStrings[1]);
            }

            result.Add(new Instruction
            { 
                Name = instructionName, 
                Value = instructionValue
            });
        }
        
        return result;
    }
}