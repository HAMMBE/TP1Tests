using TP1;
namespace TestTP1;

public class UnitTest1
{
    [Theory]
    [InlineData("FizzBuzz", 15)]
    [InlineData("Fizz", 18)]
    [InlineData("Buzz", 25)]
    [InlineData("", 14)]
    [InlineData("", 151)]
    public void TestFizzBuzz(string expected, int n)
    {
        Assert.Equal(expected, EX1.Generer(n));
    }
}