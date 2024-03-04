using PPC_Dom6.Zad1;
using PPC_Dom6.Zad2;
using PPC_Dom6.Zad3.Geometry;
using System;

namespace PPC_Dom6
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad1
            SportBall ball1 = new SportBall(6,"Volleyball",SportCategory.Collective);
            ball1.Length = 18;
            ball1.Width = 9;
            SportBall ball2 = new SportBall(1, "Table Tennis", SportCategory.SinglePlayer);
            ball2.Length = 23.7;
            ball2.Width = 8.25;
            ball1.SportCharacteristics();
            ball2.SportCharacteristics();
            //zad2
            Demo[] demos = new Demo[5];
            demos[0] = new Figure(4, 5);
            demos[1] = new Figure(6, 6);
            demos[2] = new Box(4, 5,9);
            demos[3] = new Figure(1, 7);
            demos[4] = new Box(5, 5,5);
            foreach(Demo demo in demos)
            {
                demo.Show();
                Console.WriteLine("Lice: " + demo.Lice().ToString() + "\n");
            }
            //zad3
            Square square = new Square(6);
            Rectangle rectangle = new Rectangle(4, 7);
            Console.WriteLine(square.Describe()+"\n");
            Console.WriteLine(rectangle.Describe() + "\n");
        }
    }
}
