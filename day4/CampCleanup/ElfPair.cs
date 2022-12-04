using System;

namespace AOC2022.Day4.CampCleanup
{
    public class ElfPair
    {
        public string PairAssignmentString { get; private set; }
        public bool AreAssignmentsFullyOverlapping { get; private set; }
        public bool AreAssignmentsPartiallyOverlapping { get; private set; }

        public ElfPair(string assignmentString)
		{
            this.PairAssignmentString = assignmentString;
            this.AreAssignmentsFullyOverlapping = false;
            this.AreAssignmentsPartiallyOverlapping = false;

            this.ProcessAssignmentString();
        }

        private void ProcessAssignmentString()
        {
            string[] elfAssignments = this.PairAssignmentString.Split(',');
            int elf1Start = Convert.ToInt32(elfAssignments[0].Split('-')[0]);
            int elf1End = Convert.ToInt32(elfAssignments[0].Split('-')[1]);
            int elf2Start = Convert.ToInt32(elfAssignments[1].Split('-')[0]);
            int elf2End = Convert.ToInt32(elfAssignments[1].Split('-')[1]);

            #region Check for fully overlappingassignments

            bool elf1FullyOverlap = false;
            if (elf1Start >= elf2Start && elf1End <= elf2End)
            {
                // Elf1 assignmentfits within Elf2 assignments
                elf1FullyOverlap = true;
            }

            bool elf2FullyOverlap = false;
            if (elf2Start >= elf1Start && elf2End <= elf1End)
            {
                // Elf2 assignmentfits within Elf1 assignments
                elf2FullyOverlap = true;
            }

            this.AreAssignmentsFullyOverlapping = elf1FullyOverlap || elf2FullyOverlap;

            #endregion

            #region Check for partially overlappingassignments

            this.AreAssignmentsPartiallyOverlapping = false;

            if (!this.AreAssignmentsFullyOverlapping)
            {
                if ((elf2Start <= elf1End && elf2End >= elf1Start) ||
                    (elf1Start <= elf2End && elf1End >= elf2Start))
                {
                    this.AreAssignmentsPartiallyOverlapping = true;
                }
            }

            #endregion
        }
    }
}

