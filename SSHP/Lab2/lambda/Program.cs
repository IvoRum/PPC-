using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace lambda
{
    class Program
    {
        delegate int MyDelegate(int x, int y);
        Program()
        {

        }

        void lambda_example3()
        {
            Expression<Func<int, int>> e = x => x * x;
            Func<int, int> func = e.Compile();
            Console.WriteLine(func(3));
        }

        void lambda_example2()
        {
            MyDelegate d = new MyDelegate((int x, int y) => {
                return x + y;
            });
            int sum = d(2, 3);
            Console.WriteLine(sum);
        }

        void lambda_example1()
        {
            // List to store numbers
            List<int> numbers = new List<int>() { 36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34 };

            // foreach loop to display the list
            Console.Write("The list : ");

            foreach (int value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using lambda expression
            // to calculate square of
            // each value in the list
            IEnumerable<int> square = numbers.Select(x => x * x);

            // foreach loop to display squares
            Console.Write("Squares : ");
            foreach (int value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using Lambda expression to
            // find all numbers in the list
            // divisible by 3
            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);

            Expression<Func<double, double>> e = y => Math.PI * y * y;
            
            // foreach loop to display divBy3
            Console.Write("Numbers Divisible by 3 : ");
            foreach (var value in divBy3)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Lambda 1");
            p.lambda_example1();
            Console.WriteLine("Lambda 2");
            p.lambda_example2();
            Console.WriteLine("Lambda 3");
            p.lambda_example3();
        }
    }
}