namespace Zad2;

public class BBallTeam
{
    private int points;
    private string name;
    public int Points
    {
        get => points;
        set => points = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public BBallTeam(int points, string name)
    {
        this.points = points;
        this.name = name;
    }
}