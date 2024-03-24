namespace Zad2Imoti;

public class RealEstateProperty
{
    public string Address { get; set; }
    public int NumberOfRooms { get; set; }
    public double RentAmount { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Address: {Address}, Rooms: {NumberOfRooms}, Rent: {RentAmount:C}");
    }
}