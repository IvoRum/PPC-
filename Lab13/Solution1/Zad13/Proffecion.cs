namespace Kontrolno1;

public abstract class Proffecion
{
    private string regeon;
    private string specialnost;
    private string egucation;
    private float salary;
    
    public override string ToString()
    {
        return "Regeon: " + regeon + ", Specialnost: " + specialnost +
               " , Egucation: " + egucation +
               " , Salaty " + salary.ToString();
    }
    protected Proffecion(string regeon, string specialnost, string egucation, float salary)
    {
        this.regeon = regeon;
        this.specialnost = specialnost;
        this.egucation = egucation;
        this.salary = salary;
    }

    public float calculateStafka(float Hours)
    {
        return salary / Hours;
    }

    public string Regeon
    {
        get => regeon;
        set => regeon = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Specialnost
    {
        get => specialnost;
        set => specialnost = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Egucation
    {
        get => egucation;
        set => egucation = value ?? throw new ArgumentNullException(nameof(value));
    }

    public float Salary
    {
        get => salary;
        set => salary = value;
    }


}
