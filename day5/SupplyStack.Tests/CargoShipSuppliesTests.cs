using AOC2022.Day5.SupplyStack;

namespace AOC2022.Day5.SupplyStack.Tests;

public class CargoShipSuppliesTests
{

    [Fact]
    public void InitialSuppliesParse_1Column()
    {
        string[] initialSuppliesStrings = new string[] {
            "[N]",
            "[Z]",
            " 1 " };

        CargoShip ship = new CargoShip(initialSuppliesStrings);

        List<Stack<string>> expectedStackList = new List<Stack<string>>();
        Stack<string> stack1 = new Stack<string>();
        stack1.Push("Z");
        stack1.Push("N");
        expectedStackList.Add(stack1);

        Assert.NotEmpty(ship.ShipSupplies.StackList);
        Assert.Single(ship.ShipSupplies.StackList);
        Assert.Equal(expectedStackList, ship.ShipSupplies.StackList);
    }

    [Fact]
    public void InitialSuppliesParse_2Column()
    {
        string[] initialSuppliesStrings = new string[] {
            "[D]    ",
            "[N] [C]",
            "[Z] [M]",
            " 1   2 " };

        CargoShip ship = new CargoShip(initialSuppliesStrings);

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

        Assert.NotEmpty(ship.ShipSupplies.StackList);
        Assert.Equal(expectedStackList, ship.ShipSupplies.StackList);
    }


    [Fact]
    public void InitialSuppliesParse_3Column()
    {
        string[] initialSuppliesStrings = new string[] {
            "[D]        ",
            "[N] [C]    ",
            "[Z] [M] [P]",
            " 1   2   3 " };

        CargoShip ship = new CargoShip(initialSuppliesStrings);

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

        Assert.NotEmpty(ship.ShipSupplies.StackList);
        Assert.Equal(expectedStackList, ship.ShipSupplies.StackList);
    }
}

