namespace Zad1Otpusk;

public class Rukovoditel:WorkerDecorator
{
    public override void requestVecation(int daysOf)
    {
        if (daysOf>20)
        {
            vovation.requestVecation(daysOf);
        }
        else
        {
            remainingDaysOF = remainingDaysOF - daysOf;
            Console.WriteLine("Vocation By Rukovoditel!!!!");
        }
    }

    public Rukovoditel(Dekan vovation) : base(vovation)
    {
    }
}