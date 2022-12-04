using AOC2022.Day4.CampCleanup;

namespace AOC2022.Day4.CampCleanup.Tests;

public class ElfPairTests
{
    [Theory]
    [InlineData("2-4,6-8", false)]
    [InlineData("2-3,4-5", false)]
    [InlineData("5-7,7-9", false)]
    [InlineData("2-8,3-7", true)]
    [InlineData("6-6,4-6", true)]
    [InlineData("2-6,4-8", false)]
    public void ElfPairOverlappingAssignment(string assignmentString, bool expectedIsOverlapping)
    {
        ElfPair ep = new ElfPair(assignmentString);

        Assert.Equal(expectedIsOverlapping, ep.AreAssignmentsOverlapping);
    }

    [Fact]
    public void ElfPairSampleDataOverlappingAssignment()
    {
        List<string> sampleData = Helper.GetSampleData();

        int overlapCount = 0;
        foreach(string sampleAssignmentString in sampleData)
        {
            ElfPair ep = new ElfPair(sampleAssignmentString);
            if (ep.AreAssignmentsOverlapping)
            {
                overlapCount++;
            }
        }

        Assert.Equal(2, overlapCount);
    }
}