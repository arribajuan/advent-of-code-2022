namespace AOC2022.Day10.CRTube;

public class CRT
{
    public int ScreenRows { get; set; }
    public int ScreenColumns { get; set; }

    public CRT(int screenRows, int screenColumns)
    {
        ScreenRows = screenRows;
        ScreenColumns = screenColumns;
    }

    public string DrawScreen(List<LogItem> cpuLogList)
    {
        string result = "";
        
        int cycleIndex = 0;
        for (int j = 0; j < ScreenRows; j++)
        {
            for (int i = 0; i < ScreenColumns; i++)
            {
                string characterToDisplay = ".";

                if (cycleIndex < cpuLogList.Count)
                {
                    if (i >= cpuLogList[cycleIndex].RegisterX - 1 &&
                        i <= cpuLogList[cycleIndex].RegisterX + 1)
                    {
                        characterToDisplay = "#";
                    }
                }

                result += characterToDisplay;
                cycleIndex++;
            }
            
            result += Environment.NewLine;
        }
        
        return result;
    }
}