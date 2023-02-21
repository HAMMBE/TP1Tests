using TP1;
namespace TestTP1;

public class UnitTest1
{
    [Theory]
    [InlineData("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ", 15)]
    [InlineData("", 14)]
    [InlineData("", 151)]
    public void TestFizzBuzz(string expected, int n)
    {
        Assert.Equal(expected, EX1.Generer(n));
    }
}