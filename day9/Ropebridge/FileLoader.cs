namespace AOC2022.Day9.Ropebridge;

public class FileLoader
{
    public static List<MotionInRope> LoadInput(string inputFilePath)
    {
        List<MotionInRope> result = new List<MotionInRope>();

        string[] fileLines = File.ReadAllLines(inputFilePath, System.Text.Encoding.Default);
        foreach (string fileLine in fileLines)
        {
            result.Add(new MotionInRope
            {
                Direction = fileLine.Substring(0, 1),
                Distance = Convert.ToInt32(fileLine.Substring(1, fileLine.Length - 1))
            });
        }
        
        return result;
    }
}
