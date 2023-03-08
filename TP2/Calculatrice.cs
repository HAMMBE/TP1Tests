using System.Globalization;

namespace TP2;

public class Calculatrice
{
    private IData _data;

    public Calculatrice(IData data)
    {
        _data = data;
    }

    public void Start()
    {
        _data.Afficher("Entrez le montant du prêt");
        Capital montant = new Capital(int.Parse(_data.GetInput()));
        _data.Afficher("Entrez la durée du prêt en année");
        DureeEnAnnee duree = new DureeEnAnnee(int.Parse(_data.GetInput()));
        _data.Afficher("Entrez le taux annuel");
        double tauxannuel = double.Parse(_data.GetInput(), CultureInfo.InvariantCulture);
        _data.Afficher("Etes-vous sportif ? (O/N)");
        bool isSportif = _data.GetInput().ToUpper() == "O";
        _data.Afficher("Etes-vous fumeur ? (O/N)");
        bool isFumeur = _data.GetInput().ToUpper() == "O";
        _data.Afficher("Etes-vous atteint de troubles cardiaques ? (O/N)");
        bool isTroublesCardiaques = _data.GetInput().ToUpper() == "O";
        _data.Afficher("Etes-vous ingénieur en informatique ? (O/N)");
        bool isIngenieurInformatique = _data.GetInput().ToUpper() == "O";
        _data.Afficher("Etes-vous pilote ? (O/N)");
        bool isPilote = _data.GetInput().ToUpper() == "O";
        double tauxAssurance = Assurance.CalculerTauxAssurance(isSportif, isFumeur, isTroublesCardiaques, isIngenieurInformatique, isPilote);

        _data.Afficher($"Vous allez payer {tauxAssurance}% d'assurance, et {tauxannuel}% de taux annuel");

        double mensualite = Mensualite.Calculer(montant, duree, tauxannuel);
        
        double assurance = Assurance.CalculerMensualiteAssurance(montant, tauxAssurance);
        
        double mensualiteAvecAssurance = Math.Round(mensualite + assurance, 2);
        
        _data.Afficher($"La mensualité total est de {mensualiteAvecAssurance}€, dont {assurance}€ d'assurance");
        
        double montantTotal = Mensualite.CalculerMontantTotal(mensualiteAvecAssurance, duree);
        
        double montantTotalMensualite = Mensualite.CalculerMontantTotal(mensualite, duree);
        
        double montantTotalAssurance = Mensualite.CalculerMontantTotal(assurance, duree);
        
        _data.Afficher($"Le montant total est de {montantTotal}€");
        
        _data.Afficher($"Le montant total d'interet et d'assurance est de {Math.Round(montantTotal - montant,2)}€");
        
        _data.Afficher($"Le montant total d'interet est de {Math.Round(montantTotalMensualite - montant,2)}€");
        
        _data.Afficher($"Le montant total d'assurance est de {montantTotalAssurance}€");
    }
}