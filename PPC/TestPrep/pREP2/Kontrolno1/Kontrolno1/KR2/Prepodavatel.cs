namespace Kontrolno1.KR2;

public class Prepodavatel
{
    private string firstName;
    private string lastName;
    private List<StudentGroup> _groups;

    public override string ToString()
    {
        String returns = "First name: " + firstName + " LastName: " + lastName+"Strudents: \n";
        String students="";
        foreach (var VARIABLE in _groups)
        {
            students+=VARIABLE.ToString()+"\n";
        }

        return returns + students;
    }

    public Prepodavatel(string firstName, string lastName, List<StudentGroup> groups)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        _groups = groups;
    }

    public string FirstName
    {
        get => firstName;
        set => firstName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<StudentGroup> Groups
    {
        get => _groups;
        set => _groups = value ?? throw new ArgumentNullException(nameof(value));
    }
}