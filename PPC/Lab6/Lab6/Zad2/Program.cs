// See https://aka.ms/new-console-template for more information

using PPC_Dom6.Zad2;

class Program
{
    static void Main(string[] args)
    {
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
    }
}