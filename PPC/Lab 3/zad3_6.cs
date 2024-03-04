using System;
struct SimpleStruct
{
    private int xval; //поле
    public int X      //свойство
    {
        get
        { return xval; }
        set
        { if (value < 100) xval = value; }
    }
    public void DisplayX() //метод
    { Console.WriteLine("The stored value is: {0}", xval); }
}
class TestClass
{
    public static void Main()
    {
        SimpleStruct ss = new SimpleStruct();
        Console.WriteLine("Enter a number: ");
        ss.X = int.Parse(Console.ReadLine());
        // други варианти за конвертиране:
        //ss.X = Convert.ToInt32(Console.ReadLine());
        //ss.X = Int32.Parse(Console.ReadLine());
        ss.DisplayX();
        // Console.WriteLine(ss.X); - друг вариант за отпечатване на xval
        Console.ReadLine();
    }
}
