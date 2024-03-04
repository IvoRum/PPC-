namespace upr;

public class ConcretePrototypeA:Prototype
{
    public Prototype Clone()
    {
        return (Prototype)MemberwiseClone();
    }
}