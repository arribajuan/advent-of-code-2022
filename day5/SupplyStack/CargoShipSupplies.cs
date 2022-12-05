using System;

namespace AOC2022.Day5.SupplyStack
{
	public class CargoShipSupplies
    {
        public List<Stack<int>> StackList { get; private set; }

        public CargoShipSupplies(string[] initialSuppliesStrings)
		{
			this.StackList = new List<Stack<int>>();

			this.ParseInitialSupplies(initialSuppliesStrings);
		}

		private void ParseInitialSupplies(string[] initialSuppliesStrings)
		{

		}
	}
}

