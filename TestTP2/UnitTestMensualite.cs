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
    [InlineData(0.30, false, false, false)]
    [InlineData(0.25, true, false, false)]
    [InlineData(0.45, false, true, false)]
    [InlineData(0.60, false, false, true)]
    [InlineData(0.70, true, true, true)]
    public void ShouldReturnCorrectTaux(double expected, bool isSportif, bool isFumeur, bool isCardiaque)
    {
        Assert.Equal(expected, Taux.CalculerTaux(isSportif, isFumeur, isCardiaque));
    }
}