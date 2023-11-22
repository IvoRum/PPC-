namespace Kontrolno1.KR2Zad2;
using System.IO;
using System.Text;

public class FileZad
{
    public void readFile()
    {
        String line;
        List<String> listOfWords=new List<string>();
        try
        {
            StreamReader sr =
                new StreamReader("C:\\Users\\ivail\\_Spring\\PPC-\\TestPrep\\pREP2\\Kontrolno1\\Kontrolno1\\KR2Zad2\\text.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                listOfWords.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            Console.ReadLine();
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }

        int casebr=0, breakbr=0,statement = 0;
        foreach (var word in listOfWords)
        {
            switch (word)
            {
                case "Case":
                    casebr++;
                    break;
                case"break":
                    breakbr++;
                    break;
                case "statement":
                    statement++;
                    break;
            }
        }
        
        try
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\ivail\\_Spring\\PPC-\\TestPrep\\pREP2\\Kontrolno1\\Kontrolno1\\KR2Zad2\\resultWord.txt",
                true, Encoding.ASCII);
            
            sw.Write("Case -"+casebr);
            sw.Write("break  -"+breakbr);
            sw.Write("statement  -"+statement);
            
            sw.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }
}