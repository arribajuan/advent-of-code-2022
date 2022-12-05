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
            /*      
            [N]
            [Z]
             1 

                [D]    
            [N] [C]    
            [Z] [M]
             1   2 

                [D]    
            [N] [C]    
            [Z] [M] [P]
             1   2   3

            length = 3, 7, 11, 15, 19
                if length < 3 ... no columns
                if length = 3 ... one column
                if length > 3 ... many columns

            

            // Assuming single digit column numbers (1-9)
            var count = jobId.Count(Char.IsDigit);

            for (int I = )
            foreach (string initialSuppliesString in initialSuppliesStrings)
            {
                int totalLength = initialSuppliesString.Length;
                int totalColumns = initialSuppliesString.Count(Char.IsDigit);


                int i = 0;
                do while()
            }

            */

        }


    }
}

