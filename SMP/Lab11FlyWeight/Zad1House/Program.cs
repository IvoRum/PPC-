using Zad1House;

public class Manager
{
    static void Main()
    {
        double longitude = 37.61; 
        double latitude = 55.74;

        HouseFactory houseFactory = new HouseFactory();
        House panelHouse = houseFactory.GetHouse("Panel");
        panelHouse.Build(longitude, latitude);
        
        longitude += 0.1; 
        latitude += 0.1; 
        
        House brickHouse = houseFactory.GetHouse("Brick");
        brickHouse.Build(longitude, latitude);
        longitude += 0.1; 
        latitude += 0.1; 
    }
}