namespace Zad32;

public class CarTransport:IStrategyTransport
{
    public void transpost(Pasenger pasenger)
    {
        Console.WriteLine("Trasported "+pasenger.Name+", "+pasenger.Distance+"km.");
    }
}