namespace Zad2;

public class UnderTheBasketShotTeamA:State
{
    public override void miss()
    {
        Console.Write("Under The Basket Shot TeamA MISS");
        changeState();
    }

    public override void score()
    {
        _context.TeamApoints1 += 2;
        Console.Write("Under The Basket Shot TeamA SCORE");
        changeState();
    }
}