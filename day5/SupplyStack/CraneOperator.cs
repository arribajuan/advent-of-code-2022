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

		public void ExecuteInstructions(CargoShip ship)
		{
			foreach (CraneInstruction instruction in this.CraneInstructions)
			{
				ship.MoveCrates(instruction);
			}
		}

		private void ParseCraneInstructions(string[] craneInstructionsStrings)
		{
			foreach (string craneInstructionString in craneInstructionsStrings)
			{
				this.CraneInstructions.Add(new CraneInstruction(craneInstructionString));
			}
		}
	}
}

