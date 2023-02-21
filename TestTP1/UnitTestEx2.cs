using TP1;

namespace TestTP1;

public class UnitTestEx2
{
    [Theory]
    [InlineData(0, -1)]
    [InlineData(-1, 0)]
    [InlineData(-1, -1)]
    public void TestNegativeValues(int firstPlayerExchangesWon, int secondPlayerExchangesWon)
    {
        EX2 game = new EX2(firstPlayerExchangesWon, secondPlayerExchangesWon);
        Assert.Throws<ArgumentException>(() => game.ComputeScore());
    }
    
    [Theory]
    [InlineData(0, 0, 0, 0)]
    [InlineData(1, 0, 15, 0)]
    [InlineData(2, 0, 30, 0)]
    [InlineData(3, 0, 40, 0)]
    [InlineData(4, 2, 40, 30)]
    [InlineData(2, 3, 30, 40)]
    public void ShouldReturnCorrectScore(int firstPlayerExchangesWon, int secondPlayerExchangesWon, int firstPlayerExpectedScore, int secondPlayerExpectedScore)
    {
        EX2 game = new EX2(firstPlayerExchangesWon, secondPlayerExchangesWon);
        game.ComputeScore();
        Assert.Equal(firstPlayerExpectedScore, game.FirstPlayerScore);
        Assert.Equal(secondPlayerExpectedScore, game.SecondPlayerScore);
    }
    
    [Theory]
    [InlineData(4, 0, EX2.FirstPlayer)]
    [InlineData(0, 4, EX2.SecondPlayer)]
    [InlineData(7, 5, EX2.FirstPlayer)]
    [InlineData(5, 7, EX2.SecondPlayer)]
    public void ShouldReturnCorrectWinner(int firstPlayerExchangesWon, int secondPlayerExchangesWon, string winner)
    {
        EX2 game = new EX2(firstPlayerExchangesWon, secondPlayerExchangesWon);
        game.ComputeScore();
        Assert.Equal(winner, game.Winner);
    }

}