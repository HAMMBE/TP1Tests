using TP2;

namespace TestTP2;

public class UnitTestMensualite
{
    [Fact]
    public void ShouldReturnCorrectMensualite()
    {
       Assert.Equal(508.49, Mensualite.Calculer(50000,9,2.10));
    }

    [Theory]
    [InlineData(0.30, false, false, false, false, false)]
    [InlineData(0.25, true, false, false, false, false)]
    [InlineData(0.45, false, true, false, false, false)]
    [InlineData(0.60, false, false, true, false, false)]
    [InlineData(0.25, false, false, false, true, false)]
    [InlineData(0.45, false, false, false, false, true)]
    [InlineData(0.80, true, true, true, true, true)]
    public void ShouldReturnCorrectTaux(double expected, bool isSportif, bool isFumeur, bool isCardiaque, bool isIngeInfo, bool isPilot)
    {
        Assert.Equal(expected, Assurance.CalculerTauxAssurance(isSportif, isFumeur, isCardiaque, isIngeInfo, isPilot));
    }
    
    [Theory]
    [InlineData(12.50, 50000, 0.30)]
    public void shouldReturnCorrectAssurance(double expected, int montant, double tauxAssurance)
    {
        Assert.Equal(expected, Assurance.CalculerMensualiteAssurance(montant, tauxAssurance));
    }

    [Theory]
    [InlineData(54916.92, 508.49, 9)]
    public void shouldReturnCorrectTotalMensualite(double expected, double montantMensualite, int duree)
    {
        Assert.Equal(expected, Mensualite.CalculerMontantTotal(montantMensualite, duree));
    }
}