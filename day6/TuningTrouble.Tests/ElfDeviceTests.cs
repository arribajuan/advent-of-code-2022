using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace AOC2022.Day6.TuningTrouble.Tests;

public class ElfDeviceTests
{
    [Theory]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 7)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 6)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11)]
    public void ElfEeviceFindFirstPacketMarkerIndex(string dataStream, int expectedFirstMarkerIndex)
    {
        ElfDevice device = new ElfDevice(dataStream);

        Assert.Equal(expectedFirstMarkerIndex, device.FirstPacketMarkerIndex);
    }

    [Theory]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 19)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 23)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 23)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 29)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 26)]
    public void ElfEeviceFindFirstMessageMarkerIndex(string dataStream, int expectedFirstMarkerIndex)
    {
        ElfDevice device = new ElfDevice(dataStream);

        Assert.Equal(expectedFirstMarkerIndex, device.FirstMessageMarkerIndex);
    }
}