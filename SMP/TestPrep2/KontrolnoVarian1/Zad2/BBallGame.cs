namespace Zad2;

public class BBallGame
{
    public void payGame()
    {
        Random random = new Random();
        int startShot = random.Next(0, 2);
        Context context;
        if (startShot == 0)
        {
            context = new Context(new UnderTheBasketShotTeamA());
        }
        else
        {
            context = new Context(new UnderTheBasketShotTeamB());
        }

        for (int i = 0; i < 20; i++)
        {
            int shot = random.Next(0, 2);
            if (shot == 0)
            {
                context.score();
            }
            else
            {
                context.miss();
            }
        }
        Console.WriteLine("Team A points:"+context.TeamApoints1);
        Console.WriteLine("Team B points:"+context.TeamBpoints1);
    }
    
}