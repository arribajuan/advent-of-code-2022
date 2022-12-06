namespace AOC2022.Day5.SupplyStack.Tests;

public class CargoShipTests
{
    [Fact]
    public void ShipWithInitialSupplies()
    {
        CargoShip ship = new CargoShip(Helper.GetSuppliesString_3Column()); ;
        List<Stack<string>> expectedStackList = Helper.GetExpectedStackList_3Column();

        Assert.NotEmpty(ship.ShipSupplies.StackList);
        Assert.Equal(expectedStackList, ship.ShipSupplies.StackList);
    }

    [Fact]
    public void ShipAppliesCargoMoves()
    {
        CargoShip ship = new CargoShip(Helper.GetCraneSuppliesListString()); ;
        string[] instructions = Helper.GetCraneInstructionsString();

        foreach (string instruction in instructions)
        {
            CraneInstruction ci = new CraneInstruction(instruction);
            ship.MoveCrates(ci);
        }

        List<Stack<string>> expectedStackList = Helper.GetCraneExpectedMovedStackList();
        string expectedTopOfTheStacksString = "CMZ";

        Assert.NotEmpty(ship.ShipSupplies.StackList);
        Assert.Equal(expectedStackList, ship.ShipSupplies.StackList);
        Assert.Equal(expectedTopOfTheStacksString, ship.TopOfTheStacksString);
    }
}
