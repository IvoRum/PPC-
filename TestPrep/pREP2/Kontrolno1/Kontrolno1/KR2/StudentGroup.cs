namespace Kontrolno1.KR2;

public class StudentGroup
{
    private string name;
    private string specialnost;
    private List<Student> _students;

    public override string ToString()
    {
        string returns = "Group name: "+name+"/n";
        foreach (var VARIABLE in _students)
        {
            returns += VARIABLE;
        }

        return returns;
    }

    public StudentGroup(string name, string specialnost, List<Student> students)
    {
        this.name = name;
        this.specialnost = specialnost;
        _students = students;
    }

    public void addStrunet(Student student)
    {
        _students.Add(student);
    }

    public void removeStudent(Student student)
    {
        _students.Remove(student);
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Specialnost
    {
        get => specialnost;
        set => specialnost = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Student> Students
    {
        get => _students;
        set => _students = value ?? throw new ArgumentNullException(nameof(value));
    }
}