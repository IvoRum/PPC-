namespace Zad2;

public class UnderTheBasketShotTeamB:State
{
    public override void miss()
    {
        Console.Write("Under The Basket Shot TeamB MISS");
        changeState();
    }

    public override void score()
    {
        _context.TeamBpoints1 += 2;
        Console.Write("Under The Basket Shot TeamB SCORE");
        changeState();
    }
}