using System;

namespace CSharpSchool
{
    class Explorer
    {
        public enum SortCriteria
        {
            ByName,
            ByType,
            BySize,
            ByDate
        }

        static void Main()
        {
            Console.WriteLine("Please, enter the kriteria");
            string input = Console.ReadLine();
            SortCriteria criteria;
            try
            {
                criteria = (SortCriteria)System.Enum.Parse(typeof(SortCriteria), input);
            }
            catch
            {   //Ако не въведем валиден критерий – излизане от програмата
                Console.WriteLine("You must type in a valid criteria!");
                string k = Console.ReadLine(); return;
            }

            Sort(criteria);
            Console.ReadLine();
        }
        public static void Sort(SortCriteria criteria)
        {
            switch (criteria)
            {
                case SortCriteria.ByName:
                    // code to sort by name
                    Console.WriteLine("Files/Folders sorted by name");
                    break;
                case SortCriteria.ByType:
                    // code to sort by type
                    Console.WriteLine("Files/Folders sorted by type");
                    break;
                case SortCriteria.BySize:
                    // code to sort by size
                    Console.WriteLine("Files/Folders sorted by size");
                    break;
                case SortCriteria.ByDate:
                    // code to sort by modification date
                    Console.WriteLine("Files/Folders sorted by modification date");
                    break;
            }
        }
    }
}
