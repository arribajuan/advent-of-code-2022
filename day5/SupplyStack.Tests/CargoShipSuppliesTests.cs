using AOC2022.Day5.SupplyStack;

namespace AOC2022.Day5.SupplyStack.Tests;

public class CargoShipSuppliesTests
{
    [Fact]
    public void InitialSuppliesParse_1Column()
    {
        CargoShip ship = new CargoShip(Helper.GetSuppliesString_1Column(), false);
        List<Stack<string>> expectedStackList = Helper.GetExpectedStackList_1Column();

        Assert.NotEmpty(ship.ShipSupplies.StackList);
        Assert.Single(ship.ShipSupplies.StackList);
        Assert.Equal(expectedStackList, ship.ShipSupplies.StackList);
    }

    [Fact]
    public void InitialSuppliesParse_2Column()
    {
        CargoShip ship = new CargoShip(Helper.GetSuppliesString_2Column(), false);
        List<Stack<string>> expectedStackList = Helper.GetExpectedStackList_2Column();

        Assert.NotEmpty(ship.ShipSupplies.StackList);
        Assert.Equal(expectedStackList, ship.ShipSupplies.StackList);
    }

    [Fact]
    public void InitialSuppliesParse_3Column()
    {
        CargoShip ship = new CargoShip(Helper.GetSuppliesString_3Column(), false);
        List<Stack<string>> expectedStackList = Helper.GetExpectedStackList_3Column();

        Assert.NotEmpty(ship.ShipSupplies.StackList);
        Assert.Equal(expectedStackList, ship.ShipSupplies.StackList);
    }
}

