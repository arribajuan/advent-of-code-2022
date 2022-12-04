using System;

namespace AOC2022.Day4.CampCleanup
{
    public class ElfPair
    {
        public string PairAssignmentString { get; private set; }
        public bool AreAssignmentsOverlapping { get; private set; }

        public ElfPair(string assignmentString)
		{
            this.PairAssignmentString = assignmentString;
            this.AreAssignmentsOverlapping = false;

            this.ProcessAssignmentString();
        }

        private void ProcessAssignmentString()
        {
            string[] elfAssignments = this.PairAssignmentString.Split(',');
            int elf1Start = Convert.ToInt32(elfAssignments[0].Split('-')[0]);
            int elf1End = Convert.ToInt32(elfAssignments[0].Split('-')[1]);
            int elf2Start = Convert.ToInt32(elfAssignments[1].Split('-')[0]);
            int elf2End = Convert.ToInt32(elfAssignments[1].Split('-')[1]);

            bool elf1Overlap = false;
            if (elf1Start >= elf2Start && elf1End <= elf2End)
            {
                // Elf1 assignmentfits within Elf2 assignments
                elf1Overlap = true;
            }

            bool elf2Overlap = false;
            if (elf2Start >= elf1Start && elf2End <= elf1End)
            {
                // Elf2 assignmentfits within Elf1 assignments
                elf2Overlap = true;
            }

            this.AreAssignmentsOverlapping = elf1Overlap || elf2Overlap;
        }
    }
}

