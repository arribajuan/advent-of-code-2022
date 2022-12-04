using System;

using AOC2022.Day3.Rucksack;

namespace AOC2022.Day3.Rucksack
{
    public class ElfGroup
    {
        public List<ElfRucksackGroup> RucksackGroupList { get; private set; }
        public int MisplacedItemTotalCost { get; private set; }
        public int CommonItemTotalCost { get; private set; }

        public ElfGroup()
        {
            this.RucksackGroupList = new List<ElfRucksackGroup>();
            this.MisplacedItemTotalCost = 0;
            this.CommonItemTotalCost = 0;
        }

        public void AddRucksack(ElfRucksack rucksackToAddk)
        {
            if (this.RucksackGroupList.Count == 0)
            {
                // No racksack group ... we create a new racksack group
                this.RucksackGroupList.Add(new ElfRucksackGroup());
            }
            if (this.RucksackGroupList[this.RucksackGroupList.Count - 1].RucksackList.Count == 3)
            {
                // The last racksack group has aleady 3 racksacks, its full ... we create a new racksack group
                this.RucksackGroupList.Add(new ElfRucksackGroup());
            }

            // Add racksack to teh last group
            this.RucksackGroupList[this.RucksackGroupList.Count - 1].AddRucksack(rucksackToAddk);

            this.CalculateMisplacedItemCost();
            this.CalculateCommonItemFCost();
        }

        private void CalculateMisplacedItemCost()
        {
            this.MisplacedItemTotalCost = 0;

            foreach (ElfRucksackGroup rs in this.RucksackGroupList)
            {
                this.MisplacedItemTotalCost += rs.MisplacedItemGroupCost;
            }
        }

        private void CalculateCommonItemFCost()
        {
            this.CommonItemTotalCost = 0;

            foreach (ElfRucksackGroup rs in this.RucksackGroupList)
            {
                this.CommonItemTotalCost += rs.CommonItemCost;
            }
        }
    }
}
