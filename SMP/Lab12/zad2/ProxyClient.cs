namespace zad2;

public class ProxyClient:Iclient
{
    private RealClient client;

    public ProxyClient()
    {
        client = new RealClient();
        Console.WriteLine("ProxyClient: Initialized");
    }

    public string GetData()
    {
        return client.GetData();
    }
}