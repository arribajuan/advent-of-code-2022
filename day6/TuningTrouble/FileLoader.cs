using System;

namespace AOC2022.Day6.TuningTrouble
{
    public class FileLoader
    {
        public static List<string> LoadInput(string inputFilePath)
        {
            List<string> inputStringList = new List<string>();

            string[] fileLines = File.ReadAllLines(inputFilePath, System.Text.Encoding.Default);
            inputStringList.AddRange(fileLines);

            return inputStringList;
        }
    }
}

