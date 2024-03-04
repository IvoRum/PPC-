namespace KontrolnoPPC1.Zad2;

public class Teacher : Profession
{
    private string predmets;
    private string classes;

    public Teacher(string regeon, string speciality, string education, float salary, string predmets, string classes) 
        : base(regeon, speciality, education, salary)
    {
        this.predmets = predmets;
        this.classes = classes;
    }
}