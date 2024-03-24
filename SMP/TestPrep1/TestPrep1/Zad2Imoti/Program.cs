using Zad2Imoti;

class Program
{
    static void Main(string[] args)
    {
        RentalPropertyBuilder builder = new RentalPropertyBuilder();

        builder.setAddress("Dubrovnik 18").setRent(75).setNumberOfRooms(1).build();
    }
}