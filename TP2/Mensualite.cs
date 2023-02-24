namespace TP2;

public class Mensualite
{
    public static double Calculer(int montant, int dureeEnMois, double tauxannuel)
    {
        double tauxMensuel = tauxannuel / 12 / 100;
        double mensualite = montant * tauxMensuel / (1 - Math.Pow(1 + tauxMensuel, -dureeEnMois));
        return Math.Round(mensualite, 2);
    }
}