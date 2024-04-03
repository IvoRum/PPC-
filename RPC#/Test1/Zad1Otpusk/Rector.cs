namespace Zad1Otpusk;

public class Rector:WorkerDecorator
{
    public override void requestVecation(int daysOf)
    {
        if (daysOf>45)
        {
            Console.WriteLine("Vocation DECLINED");
        }
        remainingDaysOF = remainingDaysOF - daysOf;
        Console.WriteLine("Vocation By Rector!!!!");
    }

    public Rector(Vocation vovation) : base(vovation)
    {
    }
}