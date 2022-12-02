namespace AOC2022.Day1.CalorieCounter.Tests;

public class Helper
{
	public Helper()
	{
	}

    public static List<string> GetSampleData()
    {
        string sampleDataPath = AppDomain.CurrentDomain.BaseDirectory + "sample-data.txt";

        ElfCalorieCounter ecc = new ElfCalorieCounter();
        List<string> sampleData = ecc.LoadInput(sampleDataPath);

        return sampleData;
    }

    public static List<int> GetCalorieTotals()
    {
        List<string> sampleData = GetSampleData();

        ElfCalorieCounter ecc = new ElfCalorieCounter();
        List<int> calorieTotals = ecc.CountCaloriesPerElf(sampleData);

        return calorieTotals;
    }
}

