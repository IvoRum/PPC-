using System.Collections;

namespace PPC_Dom7.Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList input = new ArrayList();
            input.Add("Servin Nikolaev Ivanov 25 52");
            input.Add("Ivan Yulianov Petkov 35 89");
            input.Add("Michail Aleksiev Nikolaev 22 73");
            input.Add("Alexxx Dimitrov Plamenov 53 121");
            input.Sort(new Zad1.StringComparer());
            foreach (Object obj in input)
            {
                Console.WriteLine((String)obj);
            }
        }
    }
}