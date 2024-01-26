// See https://aka.ms/new-console-template for more information

using PPC_Dom6.Zad1;

class Program
{
    static void Main(string[] args)
    {
        SportBall ball1 = new SportBall(6, "Volleyball", SportCategory.Collective);
        ball1.Length = 18;
        ball1.Width = 9;
        SportBall ball2 = new SportBall(1, "Table Tennis", SportCategory.SinglePlayer);
        ball2.Length = 23.7;
        ball2.Width = 8.25;
        ball1.SportCharacteristics();
        ball2.SportCharacteristics();
    }
}