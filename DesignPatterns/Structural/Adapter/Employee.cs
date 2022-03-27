namespace DesignPatterns.Structural.Adapter;

/// <summary>
/// This class is going to be used by the third party system.
/// </summary>
public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }
    public decimal Salary { get; set; }
    
    public Employee(int id, string name, string designation, decimal salary)
    {
        ID = id;
        Name = name;
        Designation = designation;
        Salary = salary; 
    }
}