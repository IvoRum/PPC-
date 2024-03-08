using zad2;

public class Manager
{
    static void Main()
    {
        ProxyClient proxy = new ProxyClient();

        Console.WriteLine("Data from Proxy Client = {0}", proxy.GetData());
    }
}