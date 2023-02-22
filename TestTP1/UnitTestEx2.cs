using TP1;

namespace TestTP1;

public class UnitTestEx2
{
    [Theory]
    [InlineData(0, 0, "Zero All")]
    [InlineData(1, 1, "Fifteen All")]
    [InlineData(2, 2, "Thirty All")]
    [InlineData(3, 3, "Deuce")]
    [InlineData(4, 4, "Deuce")]
    [InlineData(1, 0, "Fifteen - Zero")]
    [InlineData(0, 1, "Zero - Fifteen")]
    [InlineData(2, 0, "Thirty - Zero")]
    [InlineData(0, 2, "Zero - Thirty")]
    [InlineData(3, 0, "Forty - Zero")]
    [InlineData(0, 3, "Zero - Forty")]
    [InlineData(4, 0, "Game Player 1")]
    [InlineData(0, 4, "Game Player 2")]
    [InlineData(4, 3, "Advantage Player 1")]
    [InlineData(3, 4, "Advantage Player 2")]
    [InlineData(5, 3, "Game Player 1")]
    [InlineData(3, 5, "Game Player 2")]
    [InlineData(6, 4, "Game Player 1")]
    [InlineData(4, 6, "Game Player 2")]
    [InlineData(7, 5, "Game Player 1")]
    [InlineData(5, 7, "Game Player 2")]
    public void TennisGameTest(int player1Points, int player2Points, string expectedScore)
    {
        Assert.Equal(expectedScore, EX2.TennisScore(player1Points, player2Points));
    }
}