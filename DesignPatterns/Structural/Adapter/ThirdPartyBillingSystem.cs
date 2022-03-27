namespace DesignPatterns.Structural.Adapter;

public class ThirdPartyBillingSystem
{
    public void ProcessSalary(List<Employee> employees)
    {
        foreach (var employee in employees)
        {
            Console.WriteLine($"Rs. {employee.Salary} paid to {employee.Name}");
        }
    }
}