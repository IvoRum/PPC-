namespace Zad2;

public abstract class State
{
    protected Context _context;
    private Random random;

    public void SetContext(Context context)
    {
        random = new Random();

        this._context = context;
    }

    public void changeState()
    {
        int randomNumber = random.Next(0, 2);
        int shot = random.Next(0, 3);
        if (randomNumber == 0)
        {
            pickShotTeamA(shot);
        }
        else
        {
            pickShotTeamB(shot);
        }
    }

    private void pickShotTeamA(int number)
    {
        switch (number)
        {
            case 1: _context.TransitionTo(new TreePointShotTeamA());
                break;
            case 2: _context.TransitionTo(new UnderTheBasketShotTeamA());
                break;
            case 3: _context.TransitionTo(new PenaltyShotТеамА());
                break;

        }
    }
    
    private void pickShotTeamB(int number)
    {
        switch (number)
        {
            case 1: _context.TransitionTo(new TreePointShotTeamB());
                break;
            case 2: _context.TransitionTo(new UnderTheBasketShotTeamB());
                break;
            case 3: _context.TransitionTo(new PenaltyShotТеамB());
                break;

        }
    }
    
    public abstract void miss();
    public abstract void score();
}