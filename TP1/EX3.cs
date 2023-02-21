namespace TP1;

public class EX3
{
    public static string Imposition(int revenu)
    {
        if (revenu < 0)
        {
            throw new ArgumentException("Revenu must be positive");
        }
        
        switch (revenu)
        {
            case <= 10777:
                return "0% - 0";
            case <= 27478:
                return "11% - " + (revenu * 0.11);
            case <= 78570:
                return "30% - " + (revenu * 0.3);
            case <= 168994:
                return "41% - " + (revenu * 0.41);
            default:
                return "45% - " + (revenu * 0.45);
        }
        
    }
}