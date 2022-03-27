namespace DesignPatterns.Behavioural.Iterator;

public class ConcreteCollection : IAbstractCollection
{
    private List<Employee> _employees = new();
    
    public Iterator CreateIterator()
    {
        return new Iterator(this);
    }

    public int Count
    {
        get { return _employees.Count; }
    }
    
    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    public Employee GetEmployee(int index)
    {
        return _employees[index];
    }
}