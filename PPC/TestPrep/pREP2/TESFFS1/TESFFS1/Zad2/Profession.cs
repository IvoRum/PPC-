namespace KontrolnoPPC1.Zad2;

public abstract class Profession
{
    protected Profession(string regeon, string speciality, string education, float salary)
    {
        this.regeon = regeon;
        this.speciality = speciality;
        this.education = education;
        this.salary = salary;
    }

    private string regeon;
    private string speciality;
    private string education;
    private float salary;
    
    

    public string Regeon
    {
        get => regeon;
        set => regeon = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Speciality
    {
        get => speciality;
        set => speciality = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Education
    {
        get => education;
        set => education = value ?? throw new ArgumentNullException(nameof(value));
    }

    public float Salary
    {
        get => salary;
        set => salary = value;
    }

    public float calculateSalaryForHours(float Hours)
    {
        return salary / Hours;
    }

    public override string ToString()
    {
        return "Regeon: " + regeon + ", Specialit: " + speciality + ", Education: " + education + ", Salatu: " + salary;
    }
}