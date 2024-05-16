using System.Collections;

namespace Zad1;

public class Calculator
{
    private List<IMemntoCalculation> mementos;

    public Calculator()
    {
        this.mementos =new List<IMemntoCalculation>();
    }

    public void sum(int a, int b)
    {
        string formulat=$"{a} + {b}";
        int ancer = a + b;
        this.mementos.Add(new MementoCalculation(formulat,ancer.ToString()));
        Console.WriteLine(formulat+" = "+ancer);
    }

    public void squer(int a)
    {
        string formulat=$"{a} * {a}";
        int ancer = a * a;
        this.mementos.Add(new MementoCalculation(formulat,ancer.ToString()));
        Console.WriteLine(formulat+" = "+ancer);
    }

    public void getMementos()
    {
        foreach (var memento in mementos)
        {
            Console.WriteLine("Formula: "+memento.getFormula()+" = "+memento.getAncer());
        }
    }
    
}