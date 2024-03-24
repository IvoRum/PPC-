namespace Zad5Blood;

public class BasicBloodTypeCompatibility : IBloodTypeCompatibility
{
    public bool IsCompatible(BloodType donor, BloodType recipient)
    {
        // Basic compatibility logic (for demonstration)
        return donor.Group == recipient.Group || donor.Group == BloodGroup.O || recipient.Group == BloodGroup.AB;
    }
}