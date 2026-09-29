namespace CSharpHomework9.Models.Tech;

public class Laptop:Device
{
    public int Memory { get; set; }
    public int Ram { get; set; }
    
    public Laptop(string brand, string model, decimal price, int memory, int ram) : base(brand, model, price)
    {
        Memory = memory;
        Ram = ram;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Memory: {Memory}TB");
        Console.WriteLine($"Ram: {Ram} DDR 4");
    }
}