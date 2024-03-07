namespace Zad1House;

public class BrickHouse:House
{
    public BrickHouse()
    {
        stages = 5;
    }

    public override void Build(double longitude, double latitude)
    {
        Console.WriteLine("Brick House hase :"+stages+" Stages and hase Longitude: "+longitude+" and Latitude:"+latitude);
    }
}