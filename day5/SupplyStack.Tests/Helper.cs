namespace AOC2022.Day5.SupplyStack.Tests;

public class Helper
{
    public static string[] GetSuppliesString_1Column()
    {
        string[] result = new string[] {
            "[N]",
            "[Z]",
            " 1 " };

        return result;
    }

    public static string[] GetSuppliesString_2Column()
    {
        string[] result = new string[] {
            "[D]    ",
            "[N] [C]",
            "[Z] [M]",
            " 1   2 " };

        return result;
    }

    public static string[] GetSuppliesString_3Column()
    {
        string[] result = new string[] {
            "[D]        ",
            "[N] [C]    ",
            "[Z] [M] [P]",
            " 1   2   3 " };

        return result;
    }

    public static List<Stack<string>> GetExpectedStackList_1Column()
    {
        List<Stack<string>> expectedStackList = new List<Stack<string>>();

        Stack<string> stack1 = new Stack<string>();
        stack1.Push("Z");
        stack1.Push("N");
        expectedStackList.Add(stack1);

        return expectedStackList; 
    }

    public static List<Stack<string>> GetExpectedStackList_2Column()
    {
        List<Stack<string>> expectedStackList = new List<Stack<string>>();

        Stack<string> stack1 = new Stack<string>();
        stack1.Push("Z");
        stack1.Push("N");
        stack1.Push("D");
        expectedStackList.Add(stack1);

        Stack<string> stack2 = new Stack<string>();
        stack2.Push("M");
        stack2.Push("C");
        expectedStackList.Add(stack2);

        return expectedStackList;
    }

    public static List<Stack<string>> GetExpectedStackList_3Column()
    {
        List<Stack<string>> expectedStackList = new List<Stack<string>>();

        Stack<string> stack1 = new Stack<string>();
        stack1.Push("Z");
        stack1.Push("N");
        stack1.Push("D");
        expectedStackList.Add(stack1);

        Stack<string> stack2 = new Stack<string>();
        stack2.Push("M");
        stack2.Push("C");
        expectedStackList.Add(stack2);

        Stack<string> stack3 = new Stack<string>();
        stack3.Push("P");
        expectedStackList.Add(stack3);

        return expectedStackList;
    }

    public static string[] GetCraneSuppliesListString()
    {
        string[] result = new string[] {
            "    [D]    ",
            "[N] [C]    ",
            "[Z] [M] [P]",
            " 1   2   3 " };

        return result;
    }

    public static string[] GetCraneInstructionsString()
    {
        string[] result = new string[] {
            "move 1 from 2 to 1",
            "move 3 from 1 to 3",
            "move 2 from 2 to 1",
            "move 1 from 1 to 2" };

        return result;
    }

    public static List<Stack<string>> GetCraneExpectedMovedStackList()
    {
        List<Stack<string>> expectedStackList = new List<Stack<string>>();

        Stack<string> stack1 = new Stack<string>();
        stack1.Push("C");
        expectedStackList.Add(stack1);

        Stack<string> stack2 = new Stack<string>();
        stack2.Push("M");
        expectedStackList.Add(stack2);

        Stack<string> stack3 = new Stack<string>();
        stack3.Push("P");
        stack3.Push("D");
        stack3.Push("N");
        stack3.Push("Z");
        expectedStackList.Add(stack3);

        return expectedStackList;
    }
}
