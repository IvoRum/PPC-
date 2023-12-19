using System;
using System.Collections;

namespace ConsoleApplication14
{
    class Program
    {
        public class WordCounter
        {
            public static string testString = "This Is A Well-Done Program";

            SortedList wordCounter = new SortedList();
            public int UniqueWords
            {
                get { return wordCounter.Count; }
            }
            public IDictionaryEnumerator GetWordsAlphabeticallyEnumerator()
            {
                return (IDictionaryEnumerator)wordCounter.GetEnumerator();
            }
            
            public Boolean CountStats(out Int64 numWords, out Int64 numChars,string txt)
            {
                Boolean Ok = true; 
                numWords = numChars = 0;
                string[] Words = txt.Split(null);
                numWords = Words.Length; 
                for (int Word = 0; Word < numWords; Word++)
                {
                    if (Words[Word] != "")
                    {
                        numChars += Words[Word].Length;
                        if (!wordCounter.Contains(Words[Word]))
                        {
                            wordCounter.Add(Words[Word], 1);
                        }
                        else
                        {
                            wordCounter[Words[Word]] = (Int32)wordCounter[Words[Word]] + 1;
                        }
                    }
                }

                return (Ok);
            }
        }

        public static int Main()
        {
            WordCounter wc = new WordCounter();
            Int64 NumWords, NumChars;
            Console.WriteLine("\n1.Izvikvane na CountStats(out NumWords, out NumChars)");
            /*
             * New code starts here
             */
            Console.WriteLine("\n Napishi izreqenie za da byde obraboteno:");
            string testStringFromLine=Console.ReadLine();
            wc.CountStats(out NumWords, out NumChars,testStringFromLine);
            Console.WriteLine("\n2.");

            
            
            Console.WriteLine("For string\n {0}",testStringFromLine);
            Console.WriteLine("\n3.");

            Console.WriteLine("\n\nWords\tChars");
            Console.WriteLine("{0,5}\t{1,5}", NumWords, NumChars);

            Console.ReadLine();
            return 0;
        }
    }
}