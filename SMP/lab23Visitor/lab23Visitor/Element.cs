namespace lab23Visitor;

public abstract class Element
{
    public abstract void Accept(Ivisitor visitor);
}