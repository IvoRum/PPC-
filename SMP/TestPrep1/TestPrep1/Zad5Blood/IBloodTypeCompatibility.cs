namespace Zad5Blood;

public interface IBloodTypeCompatibility
{
    bool IsCompatible(BloodType donor, BloodType recipient);
}