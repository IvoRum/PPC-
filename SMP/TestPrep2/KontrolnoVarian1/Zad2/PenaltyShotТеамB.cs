namespace Zad2;

public class PenaltyShotТеамB:State
{
    public override void miss()
    {
        Console.Write("Penaly Shot TeamB MISS");
        changeState();
    }

    public override void score()
    {
        _context.TeamBpoints1 += 1;
        Console.Write("Penaly Shot TeamB SCORE");
        changeState();
    }
}