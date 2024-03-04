using System;

namespace CSharpSchool
{
    class zad3_5{
        public enum Months{
            Jan=1,
            Fav=2,
            Mar=3,
            Apr=4,
            May=5,
            Yun=6,
            Yul=7,
            Avg=8,
            Sep=9,
            Oct=10,
            Nov=11,
            Dec=12,
        }

        static void Main()
        {
            Console.WriteLine("Please, enter a month(from 1 to 12 :) )");
            int input ;
            try
            {
                input = int.Parse(Console.ReadLine()); ;
            }
            catch
            {
                Console.WriteLine("You must type in a valid criteria!");
                string k = Console.ReadLine(); return;
            }

            Sort(input);
        }
        public static void Sort(int input)
        {
            switch (input)
            {
                case ((int)Months.Dec) :
                    Console.WriteLine("Wintor");
                    break;
                case ((int)Months.Jan):
                    Console.WriteLine("Wintor");
                    break;
                case ((int)Months.Fav):
                    Console.WriteLine("Wintor");
                    break;
                case ((int)Months.Mar):
                    Console.WriteLine("Wintor");
                    break;
                case ((int)Months.Apr):
                    Console.WriteLine("Spring");
                    break;
                case ((int)Months.May):
                    Console.WriteLine("Spring");
                    break;
                case ((int)Months.Yun):
                    Console.WriteLine("Summer");
                    break;
                case ((int)Months.Yul):
                    Console.WriteLine("Summer");
                    break;
                case ((int)Months.Avg):
                    Console.WriteLine("Summer");
                    break;
                case ((int)Months.Sep):
                    Console.WriteLine("Fall");
                    break;
                case ((int)Months.Oct):
                    Console.WriteLine("Fall");
                    break;
                case ((int)Months.Nov):
                    Console.WriteLine("Fall");
                    break;

            }
            Console.ReadLine();
        }
    }
}
