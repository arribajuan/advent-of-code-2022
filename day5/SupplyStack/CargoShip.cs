using System;
using System.Collections;

namespace AOC2022.Day5.SupplyStack
{
    public class CargoShip
	{
        public string TopOfTheStacksString { get; private set; }

        public CargoShipSupplies ShipSupplies { get; private set; }

        public CargoShip(string[] initialSuppliesStrings)
		{
            this.ShipSupplies = new CargoShipSupplies(initialSuppliesStrings);
            this.FillTopOfTheStackString();
        }

        public void MoveCrates(CraneInstruction craneInstruction)
        {
            for (int i = 0; i < craneInstruction.Amount; i++)
            {
                string itemToMove = this.ShipSupplies.StackList[craneInstruction.SourceStackNumber - 1].Pop();
                this.ShipSupplies.StackList[craneInstruction.DestinationStackNumber - 1].Push(itemToMove);
            }

            this.FillTopOfTheStackString();
        }

        private void FillTopOfTheStackString()
        {
            this.TopOfTheStacksString = "";
            foreach (Stack<string> crateStack in this.ShipSupplies.StackList)
            {
                if (crateStack.Count > 0)
                {
                    this.TopOfTheStacksString += crateStack.Peek();
                }
            }
        }
    }
}

