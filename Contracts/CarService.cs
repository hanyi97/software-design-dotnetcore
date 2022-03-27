using System.Diagnostics.Contracts;

namespace Contracts;

public class CarService
{
    public void SaveCar(Car car)
    {
        Contract.Requires(car != null);
        Contract.Requires(car.Model != string.Empty);
        
        Console.WriteLine("Car saved");
    }
}