using System;

namespace AOC2022.Day5.SupplyStack
{
	public class CraneOperator
	{
		public List<CraneInstruction> CraneInstructions { get; private set; }

		public CraneOperator()
		{
			this.CraneInstructions = new List<CraneInstruction>();
		}

		// execute instructions method

		private void ParseCraneInstructions(string[] craneInstructionsStrings)
		{
			foreach (string craneInstructionString in craneInstructionsStrings)
			{
				this.CraneInstructions.Add(new CraneInstruction(craneInstructionString));
			}
		}
	}
}

