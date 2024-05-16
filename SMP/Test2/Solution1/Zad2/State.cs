namespace Zad2;

public abstract class State
{
    private Random random;
    private BBallGame game;

    public BBallGame Game
    {
        get => game;
        set => game = value ?? throw new ArgumentNullException(nameof(value));
    }


    public void setState( BBallGame game)
    {
        this.game = game;
        random = new Random();
    }

    public void changeState()
    {
        if (game.StateCounter < 20)
        {
            game.StateCounter += 1;
            int randomTeam = random.Next(0, 2);
            if (randomTeam == 0)
            {
                BBallTeam temp = game.Team;
                game.Team = game.TeamB;
                game.TeamB = temp;
            }

            calculateShot();
        }
    }

    private void calculateShot()
    {
        int shot = random.Next(0, 3);
        switch (shot)
        {
            case 0: game.TransitionTo(new TreePointShot()); 
                break;
            case 1: game.TransitionTo(new PenaltyShot());
                break;
            case 2: game.TransitionTo(new UnderTheBasketShot());
                break;
        }
    }

    public abstract void miss();
    public abstract void score();
}