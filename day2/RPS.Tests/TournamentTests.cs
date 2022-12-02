using System.Text;
using AOC2022.Day2.RPS;
namespace AOC2022.Day2.RPS.Tests;

public class TournamentTests
{

    [Theory]
    [InlineData(Enumerations.Hand.Rock, Enumerations.Hand.Rock, 4, 4)]
    [InlineData(Enumerations.Hand.Rock, Enumerations.Hand.Paper, 1, 8)]
    [InlineData(Enumerations.Hand.Rock, Enumerations.Hand.Scissor, 7, 3)]
    [InlineData(Enumerations.Hand.Paper, Enumerations.Hand.Rock, 8, 1)]
    [InlineData(Enumerations.Hand.Paper, Enumerations.Hand.Paper, 5, 5)]
    [InlineData(Enumerations.Hand.Paper, Enumerations.Hand.Scissor, 2, 9)]
    [InlineData(Enumerations.Hand.Scissor, Enumerations.Hand.Rock, 3, 7)]
    [InlineData(Enumerations.Hand.Scissor, Enumerations.Hand.Paper, 9, 2)]
    [InlineData(Enumerations.Hand.Scissor, Enumerations.Hand.Scissor, 6, 6)]
    public void PlayRound(Enumerations.Hand opponentHand, Enumerations.Hand playerHand, int expectedOpponentPoints, int expectedPlayerPoints)
    {
        // The score for a single round is the score for the shape you selected
        //  (1 for Rock, 2 for Paper, and 3 for Scissors)
        // plus the score for the outcome of the round
        //  (0 if you lost, 3 if the round was a draw, and 6 if you won).

        Round roundToPlay = new Round();
        roundToPlay.OpponentHand = opponentHand;
        roundToPlay.PlayerHand = playerHand;
        RoundResult result = Tournament.PlayRound(roundToPlay);

        Assert.Equal(expectedOpponentPoints, result.OpponentPointsThisRound);
        Assert.Equal(expectedPlayerPoints, result.PlayerPointsThisRound);
    }

    /*
    public static TournamentResult PlayTournament(List<Round> roundsToPlay)
    {
        return new TournamentResult();
    }

    // The winner of the whole tournament is the player with the highest score.
    // Your total score is the sum of your scores for each round.


    */


}