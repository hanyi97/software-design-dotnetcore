namespace DesignPatterns.Creational.Prototype;

/// <summary>
/// Prototype: Gives us a way to create new objects from the existing instance of the object.
/// That means it clone the existing object with its data into a new object. If we do any change in
/// the new object, it will not affect the existing object.
///
/// C# provides one method MemberwiseClone() which will create a new complete copy of the object.
/// </summary>
public class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }

    public Employee Clone()
    {
        return (Employee)this.MemberwiseClone();
    }
}