namespace AOC2022.Day1.CalorieCounter;

public class ElfCalorieCounter
{
    public List<string> LoadInput(string inputFilePath)
    {
        List<string> inputStringList = new List<string>();

        string[] fileLines = File.ReadAllLines(inputFilePath, System.Text.Encoding.Default);
        inputStringList.AddRange(fileLines);

        return inputStringList;
    }

    public List<int> CountCaloriesPerElf(List<string> foodList)
    {
        List<int> caloriesPerElf = new List<int>();

        throw new NotImplementedException("Not fully implemented.");

        return caloriesPerElf;
    }
}
