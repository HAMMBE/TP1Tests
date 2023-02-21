using TP1;

namespace TestTP1;

public class UnitTestEx3
{
    [Fact]
    public void TestImpot_Negatif()
    {
        Assert.Throws<ArgumentException>(() => EX3.Imposition(-1));
    }
    
    [Theory]
    [InlineData(0, "0% - 0")]
    [InlineData(11000, "11% - 1210")]
    [InlineData(28000, "30% - 8400")]
    [InlineData(80000, "41% - 32800")]
    [InlineData(169000, "45% - 76050")]
    public void TestImpot(int revenu, string expected)
    {
        Assert.Equal(expected, EX3.Imposition(revenu));
    }
}