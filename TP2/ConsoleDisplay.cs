namespace TP2;

public class ConsoleDisplay : IData
{
    public ConsoleDisplay()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
    }
    public void Afficher(object message)
    {
        Console.WriteLine(message);
    }
    
    public string GetInput()
    {
        return Console.ReadLine();
    }
}