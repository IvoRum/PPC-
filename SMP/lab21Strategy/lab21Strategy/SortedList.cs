namespace lab21Strategy;

public class SortedList
{
    private List<string> _list = new List<string>(); 

    private SortStrategy _sortstrategy;

    public SortedList(){
    }

    public void SetSortStrategy(SortStrategy sortstrategy)
    {
        _sortstrategy = sortstrategy;
    }
    
    public void Add(string name)
    {
        _list.Add(name); 
    }

    public void Sort()
    {
        _sortstrategy.Sort(_list); 
        // Претърсва списъка и показва резултатите (Iterate over list and display results) 

        foreach (string name in _list)
        {
            Console.WriteLine(" " + name);
        }
    }
}