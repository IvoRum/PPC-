namespace Zad5Blood;

public class BloodDonation
{
    private readonly IBloodTypeCompatibility _compatibility;

    public BloodType DonorType { get; }
    public BloodType RecipientType { get; }

    public BloodDonation(BloodType donorType, BloodType recipientType)
    {
        DonorType = donorType;
        RecipientType = recipientType;
        _compatibility = new BasicBloodTypeCompatibility();
    }

    public bool IsCompatible()
    {
        return _compatibility.IsCompatible(DonorType, RecipientType);
    }
}