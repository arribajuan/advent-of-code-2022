using System;

namespace AOC2022.Day3.Rucksack
{
	public class ElfRucksack
    {
		public string ItemStringFull { get; private set; }
        public string ItemStringCompartment1 { get; private set; }
        public string ItemStringCompartment2 { get; private set; }
        public List<string> MisplacedItemList { get; private set; }
        public int MisplacedItemCost { get; private set; }

        public ElfRucksack(string initialItemString)
        {
			this.ItemStringFull = initialItemString;
            this.ItemStringCompartment1 = String.Empty;
            this.ItemStringCompartment2 = String.Empty;
            this.MisplacedItemList = new List<string>();
            this.MisplacedItemCost = 0;

            this.SplitItemsIntoCompartments();
            this.FindMisplacedItems();
            this.CalculateMisplacedItemCost();
        }

        private void SplitItemsIntoCompartments()
        {
            if (this.ItemStringFull.Length > 0)
            {
                // We want the midpoint + 1 if needed
                int midPoint = (int)Math.Ceiling((double)this.ItemStringFull.Length / 2.0);

                this.ItemStringCompartment1 = this.ItemStringFull.Substring(0, midPoint);
                this.ItemStringCompartment2 = this.ItemStringFull.Substring(midPoint, this.ItemStringFull.Length - midPoint);
            }
        }

        private void FindMisplacedItems()
        {
            // Misplaced items are the onex that exist in both compartments
            this.MisplacedItemList = new List<string>();

            foreach (char c in this.ItemStringCompartment1)
            {
                if (this.ItemStringCompartment2.Contains(c.ToString()))
                {
                    if (!this.MisplacedItemList.Contains(c.ToString()))
                    {
                        this.MisplacedItemList.Add(c.ToString());
                    }
                }
            }
        }

        private void CalculateMisplacedItemCost()
        {
            // The misplaced item cost i s calculated by assigning a priority
            // value to each misplaced item and summing it up
            this.MisplacedItemCost = 0;

            foreach (string misplacedItem in this.MisplacedItemList)
            {
                this.MisplacedItemCost += Helper.GetPriorityConversion()[misplacedItem];
            }
        }
    }
}

