using System;

namespace Generics
{
    class Program
    {
        delegate void MyDeleg<T>(T x);

        delegate X MyRtrnDeleg<T, X>(T x);

        delegate C MyDelegate<A, B, C>(A a, B b);

        Program()
        {

        }

        private void delegate03()
        {
            Action<string, int> myAction = new Action<string, int>(MyMethod1);
            myAction("My string", 5);
            Func<int, string> myFunc = new Func<int, string>(MyMethod2);
            myFunc(10);
            Console.ReadLine();
        }

        private static void MyMethod1(string str, int x)
        {
            Console.WriteLine("String: " + str + ", int: " + x);
        }

        private static string MyMethod2(int x)
        {
            return "Parameter of MyMethod2() " + x;

        }

        private void delegate02()
        {
            MyDelegate<int, int, string> someDelegate = new MyDelegate<int, int, string>(MyMethod);
            Console.WriteLine("MyMethod returns: {0}", someDelegate(3, 5));
        }

        private static string MyMethod(int a, int b)
        {
            return (a + b).ToString();
        }

        private void delegate01()
        {
            MyDeleg<int> intDelegate = new MyDeleg<int>(IntMethod);
            intDelegate(5);

            MyDeleg<string> strDelegate = new MyDeleg<string>(StrMethod);
            strDelegate("my string");

            //MyRtrnDeleg<string, string> strRtrnDelegate = new MyRtrnDeleg<string, string>(StrRtrnMethod);
            //string message = strRtrnDelegate("my string");
            //Console.WriteLine(message);
        }

        private static void IntMethod(int x)
        {
            Console.WriteLine("Integer parameter method value: " + x);
        }

        private static void StrMethod(string x)
        {
            Console.WriteLine("String parameter method value: " + x);
        }

        private static string StrRtrnMethod(string x)
        {
            return ("message: " + x);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.delegate01();
            p.delegate02();
            p.delegate03();
        }
    }
}