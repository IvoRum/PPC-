namespace Zad2Imoti;

public class RentalPropertyBuilder
{
    private RealEstateProperty _property;

    public RentalPropertyBuilder setAddress(String address)
    {
        _property.Address = address;
        return this;
    }

    public RentalPropertyBuilder setNumberOfRooms(int numberOfRoom)
    {
        _property.NumberOfRooms = numberOfRoom;
        return this;
    }

    public RentalPropertyBuilder setRent(double rent)
    {
        _property.RentAmount = rent;
        return this;
    }

    public RealEstateProperty build()
    {
        return _property;
    }
}