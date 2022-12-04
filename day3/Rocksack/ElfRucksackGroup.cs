using System;

using AOC2022.Day3.Rucksack;

namespace AOC2022.Day3.Rucksack
{
	public class ElfRucksackGroup
	{
		public List<ElfRucksack> RucksackList { get; private set;}
        public int MisplacedItemGroupCost { get; private set; }

		public ElfRucksackGroup()
		{
			this.RucksackList = new List<ElfRucksack>();
			this.MisplacedItemGroupCost = 0;
		}

		public void AddRucksack(ElfRucksack rucksackToAdd)
		{
			this.RucksackList.Add(rucksackToAdd);

			this.CalculateMisplacedItemGroupCost();
		}

		private void CalculateMisplacedItemGroupCost()
		{
			this.MisplacedItemGroupCost = 0;

			foreach(ElfRucksack rs in this.RucksackList)
			{
				this.MisplacedItemGroupCost += rs.MisplacedItemCost;
			}
		}
    }
}

