namespace AOC2022.Day0.MessageGenerator.Tests;

public class GreetingsTest
{
    [Fact]
    public void HelloTest()
    {
        string expectedResult = "Hello World!";

        Greetings greetings = new Greetings();
        Assert.True(greetings.GenerateHello() == expectedResult, $"Expected '{expectedResult}'");
    }
}