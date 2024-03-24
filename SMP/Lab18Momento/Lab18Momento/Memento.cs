namespace Lab18Momento;

public class Memento
{
    string _name; 
    string _phone;
    private double _budget;

    public Memento(string name, string phone, double budget)
    {
        _name = name;
        _phone = phone;
        _budget = budget;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Phone
    {
        get => _phone;
        set => _phone = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Budget
    {
        get => _budget;
        set => _budget = value;
    }
}