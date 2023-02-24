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
    [InlineData(0.30, false)]
    [InlineData(0.25, true)]
    public void ShouldReturnCorrectTaux(double expected, bool isSportif)
    {
        Assert.Equal(expected, Taux.CalculerTaux());
    }
}