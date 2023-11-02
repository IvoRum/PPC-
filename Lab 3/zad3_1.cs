using System;

public class Zad3 {
    static void Main() {
        int max = 100, min = 1, input, br=0;
        Random random = new Random();
        int ret=random.Next(min,max);

        do {
            Console.WriteLine("Enter a number from 1 to 100(0 to quit)");
            input = int.Parse(Console.ReadLine());
            if (input > ret)
            {
                Console.WriteLine("Low, try again");
                br++;
            }
            else if (input < ret)
            {
                Console.WriteLine("Hight, try again");
                br++;
            }
            else {
                Console.WriteLine("You guessed it! the number was: {0}",ret);
                Console.WriteLine("It took you: {0} tries.",br);
                ret = random.Next(min,max);
                br = 0;
            }

           
        }while(ret>0);
        Console.WriteLine("Bye bye!");
    }

}