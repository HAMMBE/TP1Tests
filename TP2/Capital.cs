namespace TP2;

public record Capital
{
    public int Montant { get; init; }
    
    public Capital(int montant)
    {
        if (montant < 50000)
        {
            throw new ArgumentOutOfRangeException(nameof(montant), "Le montant doit être supérieur à 50000€");
        }
        Montant = montant;
    }
    
    public static implicit operator int(Capital capital) => capital.Montant;
    public static implicit operator Capital(int montant) => new(montant);
};

