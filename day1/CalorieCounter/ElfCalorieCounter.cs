using System.Linq;

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

        int calorieCount = 0;
        foreach(string snackCalories in foodList)
        {
            if (snackCalories == "")
            {
                caloriesPerElf.Add(calorieCount);
                calorieCount = 0;
            }
            else
            {
                calorieCount += Convert.ToInt32(snackCalories);
            }
        }

        if (calorieCount > 0)
        {
            caloriesPerElf.Add(calorieCount);
        }

        return caloriesPerElf;
    }

    public int FindCaloriesFromTopElf(List<int> calorieCountPerElc)
    {
        int maxCalorieTotal = calorieCountPerElc.Max();

        return maxCalorieTotal;
    }

    public int FindCaloriesFromTopThreeElves(List<int> calorieCountPerElc)
    {
        int topThreeCalorieTotal = calorieCountPerElc.OrderDescending().Take(3).Sum();

        return topThreeCalorieTotal;
    }

}
