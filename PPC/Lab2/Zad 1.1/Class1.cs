using System;
namespace Types
{ class Class1
    {  static void Main()
    {       bool f = true;
            byte b = 255;
            int x = 255;
            uint ux = 1111;
            float y = 5.5f;     // Изисква се суфикс  f, F
            decimal d = 5.5m;   // Изисква се суфикс  m, M
            double dy = 5.55;
            string s = "Hello!";
            string s1 = "25";
            object obj = new Object();
//1. System.Type GetType () –връща системния тип на текущия обект; 
//2. string ToString () – връща стринг, свързан с обекта. 
//За аритметични типове връща стойност, преобразувана в стринг; 
            Console.WriteLine("type {0} is {1} , value is {2}", "f", f.GetType(), f.ToString());    
            Console.WriteLine("type {0} is {1} , value is {2}","b", b.GetType(), b.ToString());
            Console.WriteLine("type {0} is {1} , value is {2}", "x", x.GetType(), x.ToString());
            Console.WriteLine("type {0} is {1} , value is {2}", "ux", ux.GetType(), ux.ToString());
            Console.WriteLine("type {0} is {1} , value is {2}", "y", y.GetType(), y.ToString());
            Console.WriteLine("type {0} is {1} , value is {2}", "d", d.GetType(), d.ToString());
            Console.WriteLine("type {0} is {1} , value is {2}", "dy", dy.GetType(), dy.ToString());
            Console.WriteLine("type {0} is {1} , value is {2}", "s", s.GetType(), s.ToString());
            Console.WriteLine("type {0} is {1} , value is {2}", "s1", s1.GetType(), s1.ToString());

//3.bool Equals (object obj) – проверява еквивалентността на текущия обект 
// и обекта, предаден в качестото на аргумент; 
            int a1 = 4; int a2 = 4; int a3 = 2; 
            Console.WriteLine(a1.Equals(a2)); //true
            Console.WriteLine(a1.Equals(a3)); //false
            Console.WriteLine(Equals(a1, a2)); //true
            Console.ReadLine();
        }}}
