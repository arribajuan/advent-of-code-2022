namespace AOC2022.Day5.SupplyStack.Tests;

public class CargoShipTests
{
    [Fact]
    public void ShipWithInitialSupplies()
    {
        CargoShip ship = new CargoShip(Helper.GetSuppliesString_3Column(), false);
        List<Stack<string>> expectedStackList = Helper.GetExpectedStackList_3Column();

        Assert.NotEmpty(ship.ShipSupplies.StackList);
        Assert.Equal(expectedStackList, ship.ShipSupplies.StackList);
    }

    [Theory]
    [InlineData(true, "MCD")]
    [InlineData(false, "CMZ")]
    public void ShipAppliesCargoMoves(bool isTheCraneThe9001Model, string expectedTopOfTheStacksString)
    {
        CargoShip ship = new CargoShip(Helper.GetCraneSuppliesListString(), isTheCraneThe9001Model); ;
        string[] instructions = Helper.GetCraneInstructionsString();

        foreach (string instruction in instructions)
        {
            CraneInstruction ci = new CraneInstruction(instruction);
            ship.MoveCrates(ci);
        }

        Assert.NotEmpty(ship.ShipSupplies.StackList);
        Assert.Equal(expectedTopOfTheStacksString, ship.TopOfTheStacksString);
    }
}
