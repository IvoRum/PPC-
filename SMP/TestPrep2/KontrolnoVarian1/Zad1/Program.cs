using Zad1;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.sum(4,5);
        calculator.sum(5,3);
        calculator.sum(3,12);
        calculator.sum(100,5);
        calculator.getMementos();
    }
}