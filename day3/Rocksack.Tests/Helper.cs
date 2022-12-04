using System;

using AOC2022.Day3.Rucksack;

namespace AOC2022.Day3.Rucksack.Tests
{
	public class Helper
	{
        public static List<string> GetSampleData()
        {
            string sampleDataPath = AppDomain.CurrentDomain.BaseDirectory + "sample-data.txt";
            List<string> sampleData = FileLoader.LoadInput(sampleDataPath);

            return sampleData;
        }
    }
}

