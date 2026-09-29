namespace CSharpHomework9.Models.Tech;

public class Device
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }
    
    public Device(string brand, string model, decimal price)
    {
        Brand = brand;
        Model = model;
        Price = price;
    }

    public virtual void PrintInfo()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("================");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Price: ${Price}");
    }
    
}