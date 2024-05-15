namespace Zad32;

public class Pasenger
{
    private String name;
    private int distance;

    public Pasenger(string name, int distance)
    {
        this.name = name;
        this.distance = distance;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Distance
    {
        get => distance;
        set => distance = value;
    }
}