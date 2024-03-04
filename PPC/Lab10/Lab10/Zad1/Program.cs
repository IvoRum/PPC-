using System;
using System.IO;

namespace file
{
    struct president
    {
        public string ime;
        public double uspeh;
    }

    class Program
    {
        private const string name = "test2.dat";

        static void Main()
        {
            //Създаване на нов, празен файл:
            if (File.Exists(name))
            {
                Console.WriteLine("The file {0} already exists!", name);
                FileStream ms = new FileStream(name, FileMode.Open, FileAccess.Read);
                //Създаваме Reader за файла
                BinaryReader r = new BinaryReader(ms);
                //Четене на данните от файла
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(r.ReadString());
                    Console.WriteLine(r.ReadDouble());
                }

                r.Close();
                ms.Close();
                Console.ReadKey();
                return;
            }
            else
            {
                president p;
                FileStream fs = new FileStream(name, FileMode.CreateNew);
                //Създаваме Writer за файла
                BinaryWriter w = new BinaryWriter(fs);
                //Запис на данните във файла
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("VAVEDI IME:");
                    p.ime = Console.ReadLine();
                    Console.WriteLine("VAVEDI USPEH:");
                    p.uspeh = Double.Parse(Console.ReadLine());
                    w.Write(p.ime);
                    w.Write(p.uspeh);
                }

                //Затваряне на Writer и на FileStream
                w.Close();
                fs.Close();
            }

            Console.ReadKey();
        }
    }
}