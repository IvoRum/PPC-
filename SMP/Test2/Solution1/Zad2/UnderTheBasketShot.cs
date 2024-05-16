namespace Zad2;

public class UnderTheBasketShot:State
{
    public override void miss()
    {
        Console.Write("Under The Basket Shot "+Game.Team.Name+" MISS");
        changeState();
    }

    public override void score()
    {
        Game.Team.Points += 2;
        Console.Write("Under The Basket Shot "+Game.Team.Name+" SCORE");
        changeState();
    }
    
}