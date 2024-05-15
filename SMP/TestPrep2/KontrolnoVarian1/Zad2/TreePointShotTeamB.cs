namespace Zad2;

public class TreePointShotTeamB:State
{
    public override void miss()
    {
        Console.Write("Tree Point Shot TeamB MISS");
        changeState();
    }

    public override void score()
    {
        _context.TeamBpoints1 += 3;
        Console.Write("Tree Point Shot TeamB  SCORE");
        changeState();
    }
}