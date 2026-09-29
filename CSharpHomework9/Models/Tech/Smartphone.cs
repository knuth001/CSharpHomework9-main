namespace CSharpHomework9.Models.Tech;

public class Smartphone:Device
{
    public int Framerate { get; set; }
    public int Battery { get; set; }
    
    public Smartphone(string brand, string model, decimal price, int framerate, int battery) : base(brand, model, price)
    {
        Framerate = framerate;
        Battery = battery;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Screen FPS: {Framerate}");
        Console.WriteLine($"Battery Size: {Battery}");
    }
}