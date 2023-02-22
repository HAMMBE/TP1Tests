namespace TP1;

public class EX2
{
    public static string TennisScore(int player1Points, int player2Points)
    {
        string score = string.Empty;
        string[] pointNames = { "Zero", "Fifteen", "Thirty", "Forty" };

        if (player1Points == player2Points)
        {
            if (player1Points >= 3)
            {
                score = "Deuce";
            }
            else
            {
                score = pointNames[player1Points] + " All";
            }
        }
        else if (player1Points >= 4 || player2Points >= 4)
        {
            int pointDiff = player1Points - player2Points;
            if (pointDiff == 1)
            {
                score = "Advantage Player 1";
            }
            else if (pointDiff == -1)
            {
                score = "Advantage Player 2";
            }
            else if (pointDiff >= 2)
            {
                score = "Game Player 1";
            }
            else
            {
                score = "Game Player 2";
            }
        }
        else
        {
            score = pointNames[player1Points] + " - " + pointNames[player2Points];
        }

        return score;
    }
}