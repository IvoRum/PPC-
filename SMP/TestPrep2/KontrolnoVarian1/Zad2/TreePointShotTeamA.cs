namespace Zad2;

public class TreePointShotTeamA:State
{
    public override void miss()
    {
        Console.Write("Tree Point Shot TeamA MISS");
        changeState();
    }

    public override void score()
    {
        _context.TeamApoints1 += 3;
        Console.Write("Tree Point Shot TeamA  SCORE");
        changeState();
    }
}