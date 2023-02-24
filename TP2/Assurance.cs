namespace TP2;

public class Assurance
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
        if (isPilot)
        {
            tauxAnnuel += 0.15;
        }
        
        return Math.Round(tauxAnnuel, 2);
    }

    public static double CalculerMensualiteAssurance(Capital montant, double tauxAssurance)
    {
         return Math.Round(montant * tauxAssurance / 100 / 12, 2);
    }

}