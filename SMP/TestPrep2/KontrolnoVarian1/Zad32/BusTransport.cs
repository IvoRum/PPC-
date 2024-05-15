namespace Zad32;

public class BusTransport:IStrategyTransport
{
    public void transpost(Pasenger pasenger)
    {
        Console.WriteLine("Trasported "+pasenger.Name+", "+pasenger.Distance+"km.");
    }
}