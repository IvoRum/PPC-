namespace Zad5Blood;

public class BloodType
{
    public BloodGroup Group { get; }
    public RhFactor RhFactor { get; }

    public BloodType(BloodGroup group, RhFactor rhFactor)
    {
        Group = group;
        RhFactor = rhFactor;
    }
}