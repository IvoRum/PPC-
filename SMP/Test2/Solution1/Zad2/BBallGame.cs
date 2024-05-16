namespace Zad2;

public class BBallGame
{
    private State _state = null;
    private int stateCounter;
    private BBallTeam team;
    private BBallTeam teamB;

    public int StateCounter
    {
        get => stateCounter;
        set => stateCounter = value;
    }

    public BBallTeam Team
    {
        get => team;
        set => team = value ?? throw new ArgumentNullException(nameof(value));
    }

    public BBallTeam TeamB
    {
        get => teamB;
        set => teamB = value ?? throw new ArgumentNullException(nameof(value));
    }

    public BBallGame(BBallTeam team, BBallTeam teamB)
    {
        this.team = team;
        this.teamB = teamB;
        this.TransitionTo(new PenaltyShot());
    }

    public void payGame()
    {
        stateCounter = 0;
        _state.score();
        Random random = new Random();
        int firstShot = random.Next(0, 2);
        if (firstShot == 0)
        {
            _state.score();
        }
        else
        {
            _state.miss();
        }
        for (int i = 0; i < 20; i++)
        {
            int shoot = random.Next(0, 2);
            if (shoot == 0)
            {
                _state.score();
            }
            else
            {
                _state.miss();
            }
        }
        Console.WriteLine("Team "+Team.Name+"points:"+team.Points);
        Console.WriteLine("Team "+TeamB.Name+" points:"+teamB.Points);
    }

    public void TransitionTo(State state)
    {
        Console.WriteLine($"Game transition to {state.GetType().Name}. shot for:"+team.Name);
        this._state = state;
        this._state.setState(this);
    }

}