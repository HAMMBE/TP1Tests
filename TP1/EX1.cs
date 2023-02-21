namespace TP1;

public class EX1
{
    public static string Generer(int n)
    {
        if(n < 15 || n > 150)
        {
            return string.Empty;
        }
        
        string result = string.Empty;
        
        for(int i = 1; i <= n ; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result += "FizzBuzz ";
            }
            else if (i % 3 == 0)
            {
                result += "Fizz ";
            }
            else if (i % 5 == 0)
            {
                result += "Buzz ";
            }
            else
            {
                result += i + " ";
            }
        }

        return result;
    }
}