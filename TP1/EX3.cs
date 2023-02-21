namespace TP1;

public class EX3
{
    public static string Imposition(int revenu)
    {
        if (revenu < 0)
        {
            throw new ArgumentException("Revenu must be positive");
        }
        
        if (revenu <= 10777)
        {
            return "0% - 0";
        }
        else if (revenu <= 27478)
        {
            return "11% - " + (revenu * 0.11);
        }
        else if (revenu <= 78570)
        {
            return "30% - " + (revenu * 0.3);
        }
        else if (revenu <= 168994)
        {
            return "41% - " + (revenu * 0.41);
        }
        else
        {
            return "45% - " + (revenu * 0.45);
        }
    }
}