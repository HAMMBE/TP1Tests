namespace TP2;

public class Taux
{
    public const double TauxAnnuelBase = 0.30;
    public static double CalculerTaux(bool isSportif, bool isFumeur)
    {
        if (isSportif)
        {
            return TauxAnnuelBase - 0.05;
        }
        if (isFumeur)
        {
            return Math.Round(TauxAnnuelBase + 0.15, 2);
        }
        return TauxAnnuelBase;
    }

}