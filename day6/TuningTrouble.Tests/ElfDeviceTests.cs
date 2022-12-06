namespace AOC2022.Day6.TuningTrouble.Tests;

public class ElfDeviceTests
{

    [Theory]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 7)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 6)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11)]
    public void ElfEeviceFindFirstMarkerIndex(string dataStream, int expectedFirstMarkerIndex)
    {
        ElfDevice device = new ElfDevice(dataStream);

        Assert.Equal(expectedFirstMarkerIndex, device.FirstMarkerIndex);
    }
}