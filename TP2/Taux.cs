namespace TP2;

public class Taux
{
    public const double TauxAnnuelBase = 0.30;
    public static double CalculerTaux(bool isSportif, bool isFumeur)
    {
        double tauxAnnuel = TauxAnnuelBase;
        
        if (isSportif)
        {
            tauxAnnuel -= 0.05;
        }
        if (isFumeur)
        {
            
            tauxAnnuel += 0.15;
        }
        return Math.Round(tauxAnnuel, 2);
    }

}