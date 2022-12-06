using System;
using System.Collections;

namespace AOC2022.Day5.SupplyStack
{
    public class CargoShip
	{
        public string TopOfTheStacksString { get; private set; }

        public CargoShipSupplies ShipSupplies { get; private set; }

        public bool IsCraneThe9001Model { get; private set; }

        public CargoShip(string[] initialSuppliesStrings, bool isCraneThe9001Model)
		{
            this.TopOfTheStacksString = string.Empty;
            this.ShipSupplies = new CargoShipSupplies(initialSuppliesStrings);
            this.IsCraneThe9001Model= isCraneThe9001Model;
            this.FillTopOfTheStackString();
        }

        public void MoveCrates(CraneInstruction craneInstruction)
        {
            List<string> itemsPopped = new List<string>();

            for (int i = 0; i < craneInstruction.Amount; i++)
            {
                string itemToMove = this.ShipSupplies.StackList[craneInstruction.SourceStackNumber - 1].Pop();
                itemsPopped.Add(itemToMove);
            }

            if (this.IsCraneThe9001Model)
            {
                itemsPopped.Reverse();
            }

            foreach (string itemPopped in itemsPopped)
            {
                this.ShipSupplies.StackList[craneInstruction.DestinationStackNumber - 1].Push(itemPopped);
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

