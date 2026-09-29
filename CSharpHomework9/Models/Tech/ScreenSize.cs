namespace CSharpHomework9.Models.Tech;

public class ScreenSize:Device
{
    public int Screensize { get; set; }
    
    public ScreenSize(string brand, string model, decimal price, int screensize) : base(brand, model, price)
    {
        Screensize = screensize;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Screen Size: {Screensize} inchess");
    }
}