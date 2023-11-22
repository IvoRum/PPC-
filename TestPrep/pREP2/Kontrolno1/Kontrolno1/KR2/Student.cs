namespace Kontrolno1.KR2;

public class Student
{
    private string firstName;
    private string lastName;

    public override string ToString()
    {
        return "First Name: " + firstName + "LastName: " + lastName;
    }

    public Student(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
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
}