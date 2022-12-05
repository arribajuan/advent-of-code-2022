using System;
namespace AOC2022.Day5.SupplyStack
{
	public class CraneInstruction
	{
        public int Amount { get; private set; }
        public int SourceStackNumber { get; private set; }
        public int DestinationStackNumber { get; private set; }

        public CraneInstruction(string craneInstructionString)
		{
			this.Amount = 0;
            this.SourceStackNumber = 0;
            this.DestinationStackNumber = 0;

			this.ParseCraneInstruction(craneInstructionString);
        }

		private void ParseCraneInstruction(string craneInstructionString)
		{

		}
	}
}

