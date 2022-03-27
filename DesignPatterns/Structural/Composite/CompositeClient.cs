namespace DesignPatterns.Structural.Composite;

public class CompositeClient: ClientTemplate
{
    public override string Pattern => "Composite";

    public override void RunClient()
    {
        //Creating Leaf Objects
        IComponent hardDisk = new Leaf("Hard Disk", 2000);
        IComponent ram = new Leaf("RAM", 3000);
        IComponent cpu = new Leaf("CPU", 2000);
        IComponent mouse = new Leaf("Mouse", 2000);
        IComponent keyboard = new Leaf("Keyboard", 2000);

        //Creating composite objects
        var motherBoard = new Composite("Peripherals");
        var cabinet = new Composite("Cabinet");
        var peripherals = new Composite("Peripherals");
        var computer = new Composite("Computer");
        
        // Creating a tree structure
        motherBoard.AddComponent(cpu);
        motherBoard.AddComponent(ram);
        
        // Add motherboard and hard disk into the cabinet
        cabinet.AddComponent(motherBoard);
        cabinet.AddComponent(hardDisk);
        
        // Add mouse and keyboard in peripherals
        peripherals.AddComponent(mouse);
        peripherals.AddComponent(keyboard);
        
        // Add cabinet and peripherals in computer
        computer.AddComponent(cabinet);
        computer.AddComponent(peripherals);
        
        // Display the Price of computer
        computer.DisplayPrice();
        Console.WriteLine();
        
        // Display the Price of keyboard
        keyboard.DisplayPrice();
        Console.WriteLine();
        
        // Display the Price of cabinet
        cabinet.DisplayPrice();
        Console.WriteLine();
    }
}