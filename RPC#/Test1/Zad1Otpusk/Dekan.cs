namespace Zad1Otpusk;

public class Dekan:WorkerDecorator
{
    public Dekan(Rector vovation) : base(vovation)
    {
    }
    
    public override void requestVecation(int daysOf)
    {
        if (daysOf>25)
        {
            vovation.requestVecation(daysOf);
        }
        else
        {
            remainingDaysOF = remainingDaysOF - daysOf;
            Console.WriteLine("Vocation by dekan!!!!");
        }
    }
}