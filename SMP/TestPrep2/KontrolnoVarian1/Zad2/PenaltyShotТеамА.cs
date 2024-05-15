namespace Zad2;

public class PenaltyShotТеамА:State
{
    public override void miss()
    {
        Console.Write("Penaly Shot TeamA MISS");
        changeState();
    }

    public override void score()
    {
        _context.TeamApoints1 += 1;
        Console.Write("Penaly Shot TeamA SCORE");
        changeState();
    }
}