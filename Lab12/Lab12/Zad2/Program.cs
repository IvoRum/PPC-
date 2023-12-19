using System.Text.RegularExpressions;
using System;

class Validation
{
    public static void Main()
    {
        string test = Console.In.ReadLine();
        while (test != "quit") // "quit" – за изход
        {
            Check(test);
            test = Console.In.ReadLine();
        }
    }

    static void Check(string text)
    {
        if (IsPositiveInteger(text) == true)
            Console.WriteLine("{0} - {1}", text, "Yes, Positive!");
        else
            Console.WriteLine("{0} - {1}", text, "Not Positive!");
        
        if (IsWholeNumber(text) == true)
            Console.WriteLine("{0} - {1}", text, "Yes, Whole Number");
        else
            Console.WriteLine("{0} - {1}", text, "Not Whole Number!");
        
        if (IsAlpha(text) == true)
            Console.WriteLine("{0} - {1}", text, "Yes, is Alpha!");
        else
            Console.WriteLine("{0} - {1}", text, "Not is Alpha!");
        
        if (IsAlphaNumeric(text) == true)
            Console.WriteLine("{0} - {1}", text, "Yes, is Alpha Numeric!");
        else
            Console.WriteLine("{0} - {1}", text, "Not is Alpha Numeric!");
    }

    static bool IsPositiveInteger(string number)
    {
        Regex numberRegex = new Regex("^-[1-9]");

        return !numberRegex.IsMatch(number);
    }

    public static bool IsWholeNumber(String strNumber)
    {
        Regex objNotWholePattern = new Regex("[^0-9]");
        return !objNotWholePattern.IsMatch(strNumber);
    }

    public static bool IsAlpha(String strToCheck)
    {
        Regex objAlphaPattern = new Regex("[^a-zA-Z]");
        return !objAlphaPattern.IsMatch(strToCheck);
    }
    
    public static bool IsAlphaNumeric(String strToCheck)
    {
        Regex objAlphaNumericPattern = new Regex("[^a-zA-Z0-9]");
        return !objAlphaNumericPattern.IsMatch(strToCheck);
    }
}