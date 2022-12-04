using System;

using AOC2022.Day3.Rucksack;

namespace AOC2022.Day3.Rucksack
{
	public class ElfRucksackGroup
	{
		public List<ElfRucksack> RucksackList { get; private set;}
        public int MisplacedItemGroupCost { get; private set; }
        public string CommonItem { get; private set; }
        public int CommonItemCost { get; private set; }

        public ElfRucksackGroup()
		{
			this.RucksackList = new List<ElfRucksack>();
			this.MisplacedItemGroupCost = 0;
			this.CommonItem = String.Empty;
			this.CommonItemCost = 0;
        }

		public void AddRucksack(ElfRucksack rucksackToAdd)
		{
			this.RucksackList.Add(rucksackToAdd);

			this.CalculateMisplacedItemGroupCost();
			this.FindCommonItem();
			this.CalculateCommonItemCost();
		}

		private void CalculateMisplacedItemGroupCost()
		{
			this.MisplacedItemGroupCost = 0;

			foreach(ElfRucksack rs in this.RucksackList)
			{
				this.MisplacedItemGroupCost += rs.MisplacedItemCost;
			}
		}

		private void FindCommonItem()
		{
			foreach(char c in this.RucksackList[0].ItemStringFull)
			{
				int timesFound = 0;
				for (int i = 1; i < this.RucksackList.Count; i++)
				{
                    if (this.RucksackList[i].ItemStringFull.Contains((c.ToString())))
					{
						timesFound++;
                    }
                }
				if (timesFound == (this.RucksackList.Count - 1))
				{
					this.CommonItem = c.ToString();
				}
			}
		}

		private void CalculateCommonItemCost()
		{
			if (Helper.GetPriorityConversion().ContainsKey(this.CommonItem))
			{
				this.CommonItemCost = Helper.GetPriorityConversion()[this.CommonItem];
			}
        }
    }
}