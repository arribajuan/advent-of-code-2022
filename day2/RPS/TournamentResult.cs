using System;

namespace AOC2022.Day2.RPS
{
	public class TournamentResult
	{
        public Enumerations.Outcome PlayerOutcome { get; set; }
        public int PlayerTotalPoints { get; set; }
        public int OpponentTotalPoints { get; set; }
	}
}

