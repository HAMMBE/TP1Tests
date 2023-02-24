namespace TP2;

public class Mensualite
{
    public static double Calculer(Capital montant, DureeEnAnnee duree, double tauxannuel)
    {
        double tauxMensuel = tauxannuel / 12 / 100;
        double mensualite = montant * tauxMensuel / (1 - Math.Pow(1 + tauxMensuel, -duree.ToMois()));
        return Math.Round(mensualite, 2);
    }
}