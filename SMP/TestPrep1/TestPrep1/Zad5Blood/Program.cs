using Zad5Blood;

class Program
{
    static void Main(string[] args)
    {
        // Define blood types
        BloodType donorType = new BloodType(BloodGroup.A, RhFactor.Positive);
        BloodType recipientType = new BloodType(BloodGroup.AB, RhFactor.Negative);

        // Create BloodDonation and check compatibility
        BloodDonation donation = new BloodDonation(donorType, recipientType);
        bool isCompatible = donation.IsCompatible();

        Console.WriteLine($"Is compatible: {isCompatible}");

        Console.ReadLine();
    }
}