namespace Kontrolno1;

public class Teacher:Proffecion
{
    private string predmets;
    private string classes;

    public Teacher(string regeon, string specialnost, string egucation, float salary, string predmets, string classes) : base(regeon, specialnost, egucation, salary)
    {
        this.predmets = predmets;
        this.classes = classes;
    }
}