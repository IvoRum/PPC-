using System;

public class Zad3_2{
    enum Weekdays{
        Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
    }
    static void Main()
    {
        Weekdays[] days=(Weekdays[])Enum.GetValues(typeof(Weekdays));
        foreach(Weekdays day in days){
            Console.WriteLine(day);
        }
        pickADay();
        pickANumber();
        Console.ReadLine();
    } 

    private static void pickADay(){
        Console.WriteLine("What day of the week is it?");
        string userInput = Console.ReadLine();
        Weekdays selectedDay;
        if (Enum.TryParse(userInput, true, out selectedDay))
        {
            printNumberOfDayInTheweek(selectedDay);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid day of the week.");
            pickADay();
        }
    }

    private static void printNumberOfDayInTheweek(Weekdays day){
        switch(day){
            case Weekdays.Saturday:
            Console.WriteLine("Saturday is the 5 day in the week");break;
            case Weekdays.Sunday: Console.WriteLine("Sunday is the last day in the week");  break;
            case Weekdays.Monday: Console.WriteLine("Monday is the first day in the week");break;
            case Weekdays.Tuesday: Console.WriteLine("Tuesday is the second day in the week"); break;
            case Weekdays.Wednesday: Console.WriteLine("Wednesday is the third day in the week");break;
            case Weekdays.Thursday: Console.WriteLine("Thursday is the forth day in the week");break;
            case Weekdays.Friday: Console.WriteLine("Friday is the fith day in the week");break;
        }
    }

    private static void pickANumber(){
                Console.WriteLine("What day of the week is it?");
        string userInput = Console.ReadLine();
        try {
            int selectedDay = int.Parse(userInput);
            if (selectedDay > 7 || selectedDay < 1)
            {
                Console.WriteLine("Invalid input. Please enter a valid day of the week.");
                pickANumber();
            }
            else
            {
                printNumberOfDayInTheweek(selectedDay);
            }
        }catch (FormatException)
        {
            pickANumber();
        }
    }

        private static void printNumberOfDayInTheweek(int day){
        switch(day){
            case 6: Console.WriteLine("Saturday is day you picket");break;
            case 7: Console.WriteLine("Sunday is day you picket");  break;
            case 1: Console.WriteLine("Monday is day you picket");break;
            case 2: Console.WriteLine("Tuesday is day you picket"); break;
            case 3: Console.WriteLine("Wednesday is day you picket");break;
            case 4: Console.WriteLine("Thursday is day you picket");break;
            case 5: Console.WriteLine("Friday is day you picket");break;
        }
    }
}