using TP2;

namespace TestTP2;

public class UnitTestMensualite
{
    [Fact]
    public void ShouldReturnCorrectMensualite()
    {
       Assert.Equal(508.49, Mensualite.Calculer(50000,9,2.10));
    }

    [Fact]
    public void ShouldReturnCorrectTaux()
    {
        Assert.Equal(0.30, Taux.CalculerTaux());
    }
}