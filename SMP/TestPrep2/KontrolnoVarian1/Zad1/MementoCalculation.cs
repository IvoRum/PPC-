namespace Zad1;

public class MementoCalculation :IMemntoCalculation
{
    private string _formula;
    private string _ancer;

    public MementoCalculation(string formula, string ancer)
    {
        _formula = formula;
        _ancer = ancer;
    }
    
    public string getFormula()
    {
        return _formula;
    }

    public string getAncer()
    {
        return _ancer;
    }
}