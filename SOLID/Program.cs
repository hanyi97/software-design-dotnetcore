using SOLID.LSP.Improved;

Car car = new BMW();
Console.WriteLine(car.GetColour());
car = new Audi();
Console.WriteLine(car.GetColour());