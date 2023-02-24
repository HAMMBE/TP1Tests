namespace TP2;

public record DureeEnAnnee
{
    public int Duree { get; init; }
    
    public DureeEnAnnee(int duree)
    {
        if (duree < 9 || duree > 25)
        {
            throw new ArgumentOutOfRangeException(nameof(duree), "La durée doit être comprise entre 9 et 25 ans");
        }
        Duree = duree;
    }
    
    public int ToMois() => Duree * 12; 
        
    public static implicit operator int(DureeEnAnnee duree) => duree.Duree;
    public static implicit operator DureeEnAnnee(int duree) => new(duree);
}