using System;

namespace AOC2022.Day2.RPS
{
	public class RoundResult
	{
        public Enumerations.Outcome PlayerOutcome { get; set; }
        public int PlayerPointsThisRound { get; set; }
        public int OpponentPointsThisRound { get; set; }
    }
}

