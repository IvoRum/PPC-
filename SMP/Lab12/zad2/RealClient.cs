namespace zad2;

public class RealClient:Iclient
{
    public string Data;
    public string GetData()
    {
        Console.WriteLine("Real Client: Initialized");
        this.Data = "Dot Net Tricks";
        return this.Data;
    }
}