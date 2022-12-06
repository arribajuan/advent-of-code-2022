using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace AOC2022.Day5.SupplyStack
{
	public class CargoShipSupplies
    {
        public List<Stack<string>> StackList { get; private set; }

        public CargoShipSupplies(string[] initialSuppliesStrings)
		{
			this.StackList = new List<Stack<string>>();

			this.ParseInitialSupplies(initialSuppliesStrings);
		}

		private void ParseInitialSupplies(string[] initialSuppliesStrings)
		{
            // Assuming single digit column numbers (1-9)
            string stackNumberRow = initialSuppliesStrings[initialSuppliesStrings.Length - 1];
            var stackCount = stackNumberRow.Count(Char.IsDigit);

            for(int i = 0; i < stackCount; i++)
            {
                this.StackList.Add(new Stack<string>());
            }

            // Process each row from the bottom -> up
            // so that we can "push" the items into teh stack
            for (int i = initialSuppliesStrings.Length - 2; i >= 0; i--)
            {
                string supplyString = initialSuppliesStrings[i];

                for (int j = 0; j < stackCount; j++)
                {
                    int textIndex = (j * 4) + 1;
                    string textAtIndex = supplyString[textIndex].ToString();

                    if (textAtIndex != " ")
                    {
                        this.StackList[j].Push(textAtIndex);
                    }
                }
            }
        }
    }
}

