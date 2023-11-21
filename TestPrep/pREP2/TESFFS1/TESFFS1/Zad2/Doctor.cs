namespace KontrolnoPPC1.Zad2;

public class Doctor: Profession
{
    private string ambolatorenlist;
    private string recepta;

    public Doctor(string regeon, string speciality, string education, float salary, string ambolatorenlist, string recepta) : base(regeon, speciality, education, salary)
    {
        this.ambolatorenlist = ambolatorenlist;
        this.recepta = recepta;
    }

    public string Ambolatorenlist
    {
        get => ambolatorenlist;
        set => ambolatorenlist = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Recepta
    {
        get => recepta;
        set => recepta = value ?? throw new ArgumentNullException(nameof(value));
    }
}