using AOC2022.Day2.RPS;

namespace AOC2022.Day2.RPS.Tests;

public class RPSTests
{

    [Fact]
    public void RockDefeatsScissor()
    {
        Round round = new Round();
        round.PlayerHand = Enumerations.Hand.Rock;
        round.OpponentHand = Enumerations.Hand.Scissor;

        RoundResult result = Tournament.PlayRound(round);

        Assert.Equal(Enumerations.Outcome.Win, result.PlayerOutcome);
    }

    [Fact]
    public void ScissorDefeatsPaper()
    {
        Round round = new Round();
        round.PlayerHand = Enumerations.Hand.Scissor;
        round.OpponentHand = Enumerations.Hand.Paper;

        RoundResult result = Tournament.PlayRound(round);

        Assert.Equal(Enumerations.Outcome.Win, result.PlayerOutcome);
    }

    [Fact]
    public void PaperDefeatsRock()
    {
        Round round = new Round();
        round.PlayerHand = Enumerations.Hand.Paper;
        round.OpponentHand = Enumerations.Hand.Rock;

        RoundResult result = Tournament.PlayRound(round);

        Assert.Equal(Enumerations.Outcome.Win, result.PlayerOutcome);
    }

    [Fact]
    public void SameHandTies()
    {
        Round round = new Round();
        round.PlayerHand = Enumerations.Hand.Rock;
        round.OpponentHand = Enumerations.Hand.Rock;

        RoundResult result = Tournament.PlayRound(round);

        Assert.Equal(Enumerations.Outcome.Tie, result.PlayerOutcome);
    }


}