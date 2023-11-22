namespace Kontrolno1.KR2;

public class University
{
    private string name;
    private List<Prepodavatel> _prepodavatels;
    private List<StudentGroup> _studentGroups;
    private List<Student> _students;

    public University(string name, List<Prepodavatel> prepodavatels, List<StudentGroup> studentGroups, List<Student> students)
    {
        this.name = name;
        _prepodavatels = prepodavatels;
        _studentGroups = studentGroups;
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

    public List<Prepodavatel> Prepodavatels
    {
        get => _prepodavatels;
        set => _prepodavatels = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<StudentGroup> StudentGroups
    {
        get => _studentGroups;
        set => _studentGroups = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Student> Students
    {
        get => _students;
        set => _students = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void printPrepodavatels()
    {
        foreach (var VARIABLE in _prepodavatels)
        {
            Console.WriteLine(VARIABLE.ToString());
        }
    }
}