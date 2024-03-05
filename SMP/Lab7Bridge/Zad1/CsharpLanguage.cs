namespace Zad1;

public class CsharpLanguage:Ilanguage
{
    public void Build()
    {
        Console.WriteLine("С помощта на компилатора на Roslyn компилираме изходния код в изпълним .exe.");
    }

    public void Execute()
    {
        Console.WriteLine("JIT компилира програмен бинарен код.");
        Console.WriteLine("CLR изпълняваме прекопмилирания бинарен код");
    }
}