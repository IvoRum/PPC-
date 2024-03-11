namespace Lab16Iterator;

public class Iterator:IabstractIterator
{
    Collection _collection; 
    int _current; 
    int _step;

    public Iterator(Collection collection)
    {
        this._collection = collection;
         _current = 0; 
         _step = 1;
    } 
    
    public Item First() 
    {
        _current = 0;
        return _collection[_current] as Item;
        
    } 
    
    public Item Next() 
    {_current += _step; 

        if (!IsDone) 

            return _collection[_current] as Item; 

        else return null;}

    public int Step  {get { return _step; }  set { _step = value; }} 
    
    public Item CurrentItem  
    {get { return _collection[_current] as Item; }} 
    
    public bool IsDone 
    {get { return _current >= _collection.Count; }}    
}