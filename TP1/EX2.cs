namespace TP1;

public class EX2
{
    public const string FirstPlayer = "First Player";
    public const string SecondPlayer = "Second Player";
    public int FirstPlayerExchangesWon { get; set; }
    public int FirstPlayerScore { get; set; }
    public int SecondPlayerExchangesWon { get; set; }
    public int SecondPlayerScore { get; set; }
    public string? Winner { get; set; }

    public EX2(int firstPlayerExchangesWon, int secondPlayerExchangesWon)
    {
        FirstPlayerExchangesWon = firstPlayerExchangesWon;
        SecondPlayerExchangesWon = secondPlayerExchangesWon;
    }
    public void ComputeScore()
    {
        CheckIfExchangesAreInRange();
        FirstPlayerScore = GetScore(FirstPlayerExchangesWon);
        SecondPlayerScore = GetScore(SecondPlayerExchangesWon);
       
        if (FirstPlayerExchangesWon > 3 && SecondPlayerExchangesWon < 3)
        {
            Winner = FirstPlayer;
        }
        else if (SecondPlayerExchangesWon > 3 && FirstPlayerExchangesWon < 3)
        {
            Winner = SecondPlayer;
        }
        else
        {
            if (FirstPlayerExchangesWon - SecondPlayerExchangesWon == 2)
            {
                Winner = FirstPlayer;
            }
            else if (SecondPlayerExchangesWon - FirstPlayerExchangesWon == 2)
            {
                Winner = SecondPlayer;
            }
        }
    }

    private void CheckIfExchangesAreInRange()
    {
        if (FirstPlayerExchangesWon < 0 || SecondPlayerExchangesWon < 0)
        {
            throw new ArgumentException("Exchanges must be positive");
        }
    }

    private int GetScore(int exchanges) =>
        exchanges switch
        {
            0 => 0,
            1 => 15,
            2 => 30,
            >= 3 => 40
        };
}