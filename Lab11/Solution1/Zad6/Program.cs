using System;
using System.IO;

namespace directoryLister
{
    class Program
    {
        static void Main()
        {
            DirectoryInfo dir = new DirectoryInfo("."); //текуща директория
            foreach (FileInfo f in dir.GetFiles("*.*"))
            {
                string name = f.FullName;
                long size = f.Length;
                DateTime t = f.CreationTime;
                Console.WriteLine("{0},\n{1}, {2:g}", name, size, t);
                Console.ReadLine();
            }
        }
    }
}