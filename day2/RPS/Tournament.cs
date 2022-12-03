using System;

namespace AOC2022.Day2.RPS
{
	public class Tournament
    {
		public static TournamentResult PlayTournament(List<Round> roundsToPlay)
		{
            TournamentResult result = new TournamentResult();

            foreach (Round roundToPlay in roundsToPlay)
            {
                RoundResult roundPlayed = Tournament.PlayRound(roundToPlay);
                result.OpponentTotalPoints += roundPlayed.OpponentPointsThisRound;
                result.PlayerTotalPoints += roundPlayed.PlayerPointsThisRound;
            }

            if (result.OpponentTotalPoints > result.PlayerTotalPoints)
            {
                result.PlayerOutcome = Enumerations.Outcome.Lose;
            }
            else if (result.OpponentTotalPoints < result.PlayerTotalPoints)
            {
                result.PlayerOutcome = Enumerations.Outcome.Win;
            }
            else
            {
                result.PlayerOutcome = Enumerations.Outcome.Tie;
            }

            return result;
		}

        public static RoundResult PlayRound(Round roundToPlay)
		{
			RoundResult result = new RoundResult();

            #region Calculate result based points

            // Opponent wins
            if ((roundToPlay.OpponentHand == Enumerations.Hand.Rock && roundToPlay.PlayerHand == Enumerations.Hand.Scissor) ||
                 (roundToPlay.OpponentHand == Enumerations.Hand.Paper && roundToPlay.PlayerHand == Enumerations.Hand.Rock) ||
                 (roundToPlay.OpponentHand == Enumerations.Hand.Scissor && roundToPlay.PlayerHand == Enumerations.Hand.Paper)
                )
            {
                result.OpponentPointsThisRound = 6;
                result.PlayerPointsThisRound = 0;
                result.PlayerOutcome = Enumerations.Outcome.Lose;
            }

            // Player wins
            if ((roundToPlay.PlayerHand == Enumerations.Hand.Rock && roundToPlay.OpponentHand == Enumerations.Hand.Scissor) ||
                 (roundToPlay.PlayerHand == Enumerations.Hand.Paper && roundToPlay.OpponentHand == Enumerations.Hand.Rock) ||
                 (roundToPlay.PlayerHand == Enumerations.Hand.Scissor && roundToPlay.OpponentHand == Enumerations.Hand.Paper)
                )
            {
                result.OpponentPointsThisRound = 0;
                result.PlayerPointsThisRound = 6;
                result.PlayerOutcome = Enumerations.Outcome.Win;
            }

            // Tie
            if (roundToPlay.OpponentHand == roundToPlay.PlayerHand)
			{
				result.OpponentPointsThisRound = 3;
				result.PlayerPointsThisRound = 3;
				result.PlayerOutcome = Enumerations.Outcome.Tie;
			}

            #endregion

            #region Calculate hand shape based points

            switch (roundToPlay.OpponentHand)
            {
                case Enumerations.Hand.Rock:
                    result.OpponentPointsThisRound += 1;
                    break;
                case Enumerations.Hand.Paper:
                    result.OpponentPointsThisRound += 2;
                    break;
                case Enumerations.Hand.Scissor:
                    result.OpponentPointsThisRound += 3;
                    break;
            }

            switch (roundToPlay.PlayerHand)
            {
                case Enumerations.Hand.Rock:
                    result.PlayerPointsThisRound += 1;
                    break;
                case Enumerations.Hand.Paper:
                    result.PlayerPointsThisRound += 2;
                    break;
                case Enumerations.Hand.Scissor:
                    result.PlayerPointsThisRound += 3;
                    break;
            }

            #endregion

            return result;
		}
    }
}

