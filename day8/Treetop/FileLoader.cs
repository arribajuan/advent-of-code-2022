namespace AOC2022.Day8.Treetop
{
    public class FileLoader
    {
        public static int[,] LoadInput(string inputFilePath)
        {
            string[] fileLines = File.ReadAllLines(inputFilePath, System.Text.Encoding.Default);
            int totalRows = fileLines.Length;
            int totalColumns = fileLines[0].Length;

            int[,] result = new int[totalRows, totalColumns];

            for (int i = 0; i < fileLines.Length; i++)
            {
                string fileLine = fileLines[i];

                for (int j = 0; j < fileLine.Length; j++)
                {
                    result[i, j] = Convert.ToInt32(fileLine.Substring(j, 1));
                }
            }
            
            return result;
        }
    }
}