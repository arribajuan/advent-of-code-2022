namespace AOC2022.Day11.MITM;

public class Monkey
{
    public int MonkeyNumber { get; set; }
    public List<int> ItemsHeld { get; set; }
    public string OperationName { get; set; }
    public string OperationValueType { get; set; }
    public int OperationValue { get; set; }
    public int TestValue { get; set; }
    public int TestTargetMonkeyIfTrue { get; set; }
    public int TestTargetMonkeyIfFalse { get; set; }

    public Monkey()
    {
        MonkeyNumber = 0;
        ItemsHeld = new List<int>();
        OperationName = String.Empty;
        OperationValueType = String.Empty;
        OperationValue = 0;
        TestValue = 0;
        TestTargetMonkeyIfTrue = 0;
        TestTargetMonkeyIfFalse = 0;
    }
}