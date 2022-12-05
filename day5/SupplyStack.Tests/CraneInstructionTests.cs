using AOC2022.Day5.SupplyStack;

namespace AOC2022.Day5.SupplyStack.Tests;

public class CraneInstructionTests
{
    [Theory]
    [InlineData("move 1 from 2 to 1", 1, 2, 1)]
    [InlineData("move 3 from 1 to 3", 3, 1, 3)]
    [InlineData("move 2 from 2 to 1", 2, 2, 1)]
    [InlineData("move 1 from 1 to 2", 1, 1, 2)]
    public void CraneInstructionParse(string craneInstructionString, int expectedAmount, int expectedSourceStackNumber, int expectedDestinationStackNumber)
    {
        CraneInstruction ci = new CraneInstruction(craneInstructionString);

        Assert.Equal(expectedAmount, ci.Amount);
        Assert.Equal(expectedSourceStackNumber, ci.SourceStackNumber);
        Assert.Equal(expectedDestinationStackNumber, ci.DestinationStackNumber);
    }
}