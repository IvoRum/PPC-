using System;

namespace AnonimusFuctions
{
    delegate void NumberChanger(int n);
    delegate long PowerNumber(int x, int y);
    delegate double AvarageCalc(int[] arr); 
    
    class Program
    {
        static int num = 10;

        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method: {0}", num);
        }
        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method: {0}", num);
        }
        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            AvarageCalc avarageCalc = delegate(int[] arrs)
            {
                double avr = 0;
                foreach (var VARIABLE in arrs)
                {
                    avr += VARIABLE;
                }
                return avr / arrs.Length;
            };
            //create delegate instances using anonymous method
            NumberChanger nc = delegate (int x) {
                Console.WriteLine("Anonymous Method: {0}", x);
            };

            //calling the delegate using the anonymous method 
            nc(10);

            //instantiating the delegate using the named methods 
            nc = new NumberChanger(AddNum);

            //calling the delegate using the named methods 
            nc(5);

            //instantiating the delegate using another named methods 
            nc = new NumberChanger(MultNum);

            //calling the delegate using the named methods 
            nc(2);

            PowerNumber pn = delegate (int x, int y)
            {
                Console.WriteLine("Anonymous method called");
                long result = 1;
                for (int i = 1; i < y + 1; i++)
                {
                    result = result * x;
                }
                return result;
            };
            long res = pn(3, 10);
            Console.WriteLine("Result: " + res);
            Console.WriteLine("Avvarage: {0}",avarageCalc(new []{1,2,3,23,3,2,123,1,23,12,3}));
        }
    }
    }