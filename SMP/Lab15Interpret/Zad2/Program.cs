using Zad2;

public class Manager
{
    static void Main()
    {
        string roman = "MCMXXVIII";  
        Context context = new Context(roman); 
        List<Expression> tree = new List<Expression>(); 
        tree.Add(new ThousandExpression()); 
        tree.Add(new HundredExpression()); 
        tree.Add(new TenExpression()); 
        tree.Add(new OneExpression()); 
        // Интерпретатор 

        foreach (Expression exp in tree) 
        {exp.Interpret(context); } 

        Console.WriteLine("{0} = {1}", roman, context.Output); 
    }
}