namespace Lab16Iterator;

public interface IabstractIterator
{
    public Item First(); 

    public Item Next(); 

    public bool IsDone { get; } 

    public Item CurrentItem { get; }
}