namespace Zad1;

public abstract class Programmer
{
    private Ilanguage language;

    public Ilanguage Language
    {
        set { language = value; }
    }
    
    public Programmer (Ilanguage lang) {language=lang;}

    public virtual void DoWork()
    {
        language.Build(); 
        language.Execute(); 
    }

    public abstract void EarnMoney();
}