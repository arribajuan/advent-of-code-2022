using System.Text;

namespace AOC2022.Day9.Ropebridge;

public class FileLoader
{
    public static List<MotionInRope> LoadInput(string inputFilePath)
    {
        var result = new List<MotionInRope>();

        var fileLines = File.ReadAllLines(inputFilePath, Encoding.Default);
        foreach (var fileLine in fileLines)
            result.Add(new MotionInRope
            {
                Direction = fileLine.Substring(0, 1),
                Distance = Convert.ToInt32(fileLine.Substring(1, fileLine.Length - 1))
            });

        return result;
    }
}