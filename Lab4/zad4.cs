using System;
class MyAge
{   public static int age = 30; //имаме статичен член
    public MyAge()          //имаме конструктор, който не е static
    { age += 5; }
}
class Test
{    static void Main()
    {	/*Достъпът до статичния член не може да стане по стадартния начин,
        а именно след създаване на инстанция на класа, тоест не е допустимо да напишем:
        MyAge s = new MyAge();
        s.age = 20; */
        //Достъпът става чрез името на самия клас:
        Console.WriteLine(MyAge.age); 
                       // Какво е извежда? Извиква ли се конструктора?
        MyAge.age = 20;
        Console.WriteLine(MyAge.age);  // Какво е извежда?
        //Но ако създадем инстанция?
        MyAge s = new MyAge();        //тогава:
        Console.WriteLine(MyAge.age); // Какво е извежда?
        Console.ReadLine();
    }
}
