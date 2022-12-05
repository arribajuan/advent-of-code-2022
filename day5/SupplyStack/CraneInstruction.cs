using System;

namespace AOC2022.Day5.SupplyStack
{
	public class CraneInstruction
	{
        public string InstructionType { get; private set; }
        public int Amount { get; private set; }
        public int SourceStackNumber { get; private set; }
        public int DestinationStackNumber { get; private set; }

        public CraneInstruction(string craneInstructionString)
		{
            this.InstructionType = String.Empty;
			this.Amount = 0;
            this.SourceStackNumber = 0;
            this.DestinationStackNumber = 0;

			this.ParseCraneInstruction(craneInstructionString);
        }

		private void ParseCraneInstruction(string craneInstructionString)
		{
            string[] stringSplit = craneInstructionString.Split(' ');
            this.InstructionType = stringSplit[0];
            this.Amount = Convert.ToInt32(stringSplit[1]);
            this.SourceStackNumber = Convert.ToInt32(stringSplit[3]);
            this.DestinationStackNumber = Convert.ToInt32(stringSplit[5]);
        }
    }
}

