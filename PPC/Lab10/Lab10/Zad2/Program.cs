using System;
using System.IO;
namespace file
{    class Program
    {   private const string name = "proba.txt";
        static void Main()
        {//Ако файлът съществува, то го прочитаме
            if (File.Exists(name))
            {//търси се \bin\Debug\proba.txt
                Console.WriteLine("The file {0} already exists!", name);
                Console.ReadKey();
                //Създаваме Reader за файла
                StreamReader r = new StreamReader(name);
                //Четене на данните от файла
                string input;
                while ((input = r.ReadLine()) != null)
                    Console.WriteLine(input);
                Console.ReadKey();
                return;
            }
            else  //Ако файлът не съществува, то го създаваме
            {   //Създаваме Writer за файла
                StreamWriter sw = File.CreateText(name);
                //Запис на данните във файла
                sw.WriteLine("{0},{1},{2}","Ivan Ivanov", 1956, "Varna");
                //Затваряне на Writer и на FileStream
                sw.Close();
                Console.WriteLine("The file {0} is created!!!", name);               
                Console.ReadKey();
            }
        }
    }
}