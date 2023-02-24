using TP2;

namespace TestTP2;

public class UnitTestMensualite
{
    [Fact]
    public void ShouldReturnCorrectMensualite()
    {
       Assert.Equal(508.40, Mensualite.Calculer(50000,108,2.10));
    }
}