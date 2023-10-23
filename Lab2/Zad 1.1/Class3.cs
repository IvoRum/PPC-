using System;
class Test_boxing_GetType
{      static void Main()
      {float pi = 3.1415f;             //тип стойност
object b=new object();    //референтен тип-object
Console.WriteLine("{0}", b.GetType()); //System.Object
b=pi;                                  // pi се опакова в b
Console.WriteLine("b={0}, b.GetType={1}",pi, b.GetType());      
                                 //b=3.1415,… System.Single
int i = 10; b = i;               // i се опакова в b
Console.WriteLine("b={0}, b.GetType={1}", b, b.GetType());  
//b=10,… System.Int32
Console.ReadLine();
      }
}
