namespace Lab16Iterator;

public class Item
{
    private string _name;

    public Item(string name)
    {
        _name = name;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }
}