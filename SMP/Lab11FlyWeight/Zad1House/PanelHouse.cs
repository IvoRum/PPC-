namespace Zad1House;

public class PanelHouse:House
{
    public PanelHouse()
    {
        stages = 16;
    }

    public override void Build(double longitude, double latitude)
    {
        Console.WriteLine("Panel House hase :"+stages+" Stages and hase Longitude: "+longitude+" and Latitude:"+latitude);
    }
}