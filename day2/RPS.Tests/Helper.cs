using System;
using AOC2022.Day2.RPS;

namespace AOC2022.Day2.RPS.Tests
{
	public class Helper
	{
        public static List<string> GetSampleData()
        {
            string sampleDataPath = AppDomain.CurrentDomain.BaseDirectory + "sample-data.txt";
            List<string> sampleData = FileLoader.LoadInput(sampleDataPath);

            return sampleData;
        }

        public static List<Round> GetDecryptedElfStrategyGuide()
        {
            List<Round> decryptedElfStrategyGuide = ElfStrategyGuide.Decrypt(GetSampleData());

            return decryptedElfStrategyGuide;
        }
    }
}

