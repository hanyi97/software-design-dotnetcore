namespace DesignPatterns.Structural.Adapter;

/// <summary>
/// Adapter: Adapts the interface of a class to another interface clients expect.
///
/// The ProcessCompanySalary method receives the employee information as a string array
/// and then converts the information to a Employee object which will be added to the employee list.
/// 
/// It will then call the ProcessSalary method on the ThirdPartyBillingSystem providing the list of employees.
/// </summary>
public class EmployeeAdapter : ITarget
{
    ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();
    
    public void ProcessCompanySalary(string[,] employeesArr)
    {
        string id = null;
        string name = null;
        string designation = null;
        string salary = null;
        
        var listEmployees = new List<Employee>();

        for (var i = 0; i < employeesArr.GetLength(0); i++)
        {
            for (var j = 0; j < employeesArr.GetLength(1); j++)
            {
                switch (j)
                {
                    case 0:
                        id = employeesArr[i, j];
                        break;
                    case 1:
                        name = employeesArr[i, j];
                        break;
                    case 2:
                        designation = employeesArr[i, j];
                        break;
                    default:
                        salary = employeesArr[i, j];
                        break;
                }
            }
            listEmployees.Add(new Employee(Convert.ToInt32(id), name, designation, Convert.ToDecimal(salary)));
        }
        Console.WriteLine("Adapter converted Array of Employees to List of Employees");
        Console.WriteLine("Then delegate to ThirdPartyBillingSystem to process the salary");
        thirdPartyBillingSystem.ProcessSalary(listEmployees);
    }
}