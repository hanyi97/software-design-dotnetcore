namespace DesignPatterns.Behavioural.Iterator;

/// <summary>
/// Iterator: Allows sequential access of elements without exposing the inside logic.
/// </summary>
public class Iterator : IAbstractIterator
{
    private ConcreteCollection _collection;
    private int current = 0;
    private int step = 1;
    
    public Iterator(ConcreteCollection collection)
    {
        _collection = collection;
    }
    
    public Employee First()
    {
        current = 0;
        return _collection.GetEmployee(current);
    }

    public Employee Next()
    {
        current += step;
        if (!IsCompleted)
            return _collection.GetEmployee(current);
        else
            return null;
    }

    public bool IsCompleted
    {
        get { return current >= _collection.Count;  }
    }
}