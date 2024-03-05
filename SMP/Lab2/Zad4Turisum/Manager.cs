namespace Zad4Turisum;

public class Manager
{
    static void Main()
    {
        Console.WriteLine("Welcome! \n Pick a course");
        Console.WriteLine(" 1.{0} \n 2.{1} \n 3.{2}",Theme.Sports,Theme.History,Theme.Cuisine);
        string course = Console.In.ReadLine();
        Theme pikedTheme=Theme.Undefined;
        switch (course)
        {
            case "1":Console.WriteLine("You have chosen:{0}",Theme.Sports);
                pikedTheme = Theme.Sports; break;
            case "2":Console.WriteLine("You have chosen:{0}",Theme.History);
                pikedTheme = Theme.History; break;
            case "3": Console.WriteLine("You have chosen:{0}",Theme.Cuisine);
                pikedTheme = Theme.Cuisine;break;

        }
        Console.WriteLine("Now Please fill in the document \n What is your name?");
        string name = Console.In.ReadLine();
        Console.WriteLine("What country do you want to visit?");
        string contry = Console.In.ReadLine();
        Console.WriteLine("What is your budget?");
        string price = Console.In.ReadLine();

        Kurs kurs = new Kurs(name,contry,price,pikedTheme);
        
        Console.WriteLine("Your copy of the filed in data: {0}",kurs.ShallowCopy().ToString());
    }
}