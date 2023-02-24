namespace TP2;

public class Taux
{
    public const double TauxAnnuelBase = 0.30;
    public static double CalculerTauxAssurance(bool isSportif, bool isFumeur, bool isCardiaque, bool isIngeInfo, bool isPilot)
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
        if (isCardiaque)
        {
            tauxAnnuel += 0.30;
        }
        if (isIngeInfo)
        {
            tauxAnnuel -= 0.05;
        }
        
        return Math.Round(tauxAnnuel, 2);
    }

}