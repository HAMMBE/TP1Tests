namespace TP2;

public class Calculatrice
{
    IData _data;
    
    public Calculatrice(IData data)
    {
        _data = data;
    }
    
    public void CalculerMensualite(Capital montant, DureeEnAnnee duree, double tauxannuel)
    {
        double mensualite = Mensualite.Calculer(montant, duree, tauxannuel);
        _data.Afficher($"La mensualité est de {mensualite}€");
    }
    
    public void Start()
    {
        _data.Afficher("Entrez le montant du prêt");
        Capital montant = new Capital(int.Parse(_data.GetInput()));
        _data.Afficher("Entrez la durée du prêt en année");
        DureeEnAnnee duree = new DureeEnAnnee(int.Parse(Console.ReadLine()));
        _data.Afficher("Entrez le taux annuel");
        double tauxannuel = double.Parse(Console.ReadLine());
        CalculerMensualite(montant, duree, tauxannuel);
    }
}