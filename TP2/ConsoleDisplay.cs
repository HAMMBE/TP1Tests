namespace TP2;

public class ConsoleDisplay : IData
{
    public void Afficher(object message)
    {
        Console.WriteLine(message);
    }
    
    public string GetInput()
    {
        return Console.ReadLine();
    }
}