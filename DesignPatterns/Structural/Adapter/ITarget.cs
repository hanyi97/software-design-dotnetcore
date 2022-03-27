namespace DesignPatterns.Structural.Adapter;

public interface ITarget
{
    void ProcessCompanySalary(string[,] employeesArr); // [,] means 2D array
}