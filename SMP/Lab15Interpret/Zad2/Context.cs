namespace Zad2;

public class Context
{
    string _input;
    private int _output;

    public Context(string input)
    {
        _input = input;
    }

    public string Input
    {
        get => _input;
        set => _input = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Output
    {
        get => _output;
        set => _output = value;
    }
}