namespace Zad1Otpusk;

public abstract class WorkerDecorator:Vocation
{
    protected int remainingDaysOF=45;
    protected Vocation vovation;

    protected WorkerDecorator( Vocation vovation)
    {
        this.vovation = vovation;
    }

    public override void requestVecation(int daysOf)
    {
        vovation.requestVecation(daysOf);
    }
}

