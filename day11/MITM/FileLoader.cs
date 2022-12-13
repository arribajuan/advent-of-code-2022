using System.Diagnostics;
using System.Text;

namespace AOC2022.Day11.MITM;

public class FileLoader
{
    public static List<Monkey> LoadInput(string inputFilePath)
    {
        var result = new List<Monkey>();

        var fileLines = File.ReadAllLines(inputFilePath, Encoding.Default);
        for (int i = 0; i < fileLines.Length; i++)
        {
            string fileLine = fileLines[i];
            
            if (fileLine.Length > 7)
            {
                if (fileLine.Substring(0, 7) == "Monkey ")
                {
                    Monkey newMonkey = new Monkey();
                    
                    newMonkey.MonkeyNumber = Convert.ToInt32((fileLine.Substring(7, (fileLine.Length - 1) - 7)));
                   
                    #region Parse items
                    
                    string fileLine2 = fileLines[i + 1].Substring(17, fileLines[i + 1].Length - 17); 
                    foreach (string item in fileLine2.Split(','))
                    {
                        newMonkey.ItemsHeld.Add(Convert.ToInt64(item));
                    }

                    #endregion
                    
                    #region Parse operation
                    
                    string[] fileLine3 = fileLines[i + 2].Substring(23, fileLines[i + 2].Length - 23).Split(' ');
                    
                    newMonkey.OperationName = fileLine3[0];
                    if (fileLine3[1] == "old")
                    {
                        newMonkey.OperationValueType = "old";
                        newMonkey.OperationValue = 0;
                    }
                    else
                    {
                        newMonkey.OperationValueType = "value";
                        newMonkey.OperationValue = Convert.ToInt32(fileLine3[1]);
                    }

                    #endregion
                    
                    #region Parse test
                    
                    string fileLine4 = fileLines[i + 3].Substring(21, fileLines[i + 3].Length - 21);
                    string fileLine5 = fileLines[i + 4].Substring(29, fileLines[i + 4].Length - 29);
                    string fileLine6 = fileLines[i + 5].Substring(30, fileLines[i + 5].Length - 30);

                    newMonkey.TestValue = Convert.ToInt32(fileLine4);
                    newMonkey.TestTargetMonkeyIfTrue = Convert.ToInt32(fileLine5);
                    newMonkey.TestTargetMonkeyIfFalse = Convert.ToInt32(fileLine6);
                    
                    #endregion

                    result.Add(newMonkey);
                }
            }
        }
        
        return result;
    }
}