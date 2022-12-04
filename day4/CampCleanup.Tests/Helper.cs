using System;

namespace AOC2022.Day4.CampCleanup.Tests
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

