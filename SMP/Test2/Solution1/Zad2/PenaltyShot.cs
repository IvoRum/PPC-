namespace Zad2;

public class PenaltyShot:State
{
    public override void miss()
    {
        Console.Write("Penalty Shot "+Game.Team.Name+" MISS");
        changeState();
    }

    public override void score()
    {
        Game.Team.Points += 1;
        Console.Write("Penalty Shot " + Game.Team.Name + " SCORE");
        changeState();
    }
}