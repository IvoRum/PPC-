namespace Zad2;

public class TreePointShot:State
{
    public override void miss()
    {
        Console.Write("Tree Point Shot "+Game.Team.Name+" MISS");
        changeState();
    }

    public override void score()
    {
        Game.Team.Points += 3;
        Console.Write("Tree Point Shot "+Game.Team.Name+"  SCORE");
        changeState();
    }
}