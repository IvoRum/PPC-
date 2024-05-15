namespace Zad32;

public class TaxiTransport : IStrategyTransport
{
    public void transpost(Pasenger pasenger)
    {
        float howers = 34 * pasenger.Distance;
        Console.WriteLine("Trasported " + pasenger.Name + ", " + pasenger.Distance + "km for " + howers +
                          "h. Whit speed of: 34 km/h ");
    }
}