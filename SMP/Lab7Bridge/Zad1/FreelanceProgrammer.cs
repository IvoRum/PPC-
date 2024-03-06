namespace Zad1;

public class FreelanceProgrammer :Programmer
{
    public FreelanceProgrammer(Ilanguage lang) : base(lang)
    {
    }

    public override void EarnMoney()
    {
        Console.WriteLine("Получавате заплащане за изпълнението на задачата");
    }
}