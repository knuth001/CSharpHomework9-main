namespace CSharpHomework9.Models.Tech;

public class Tablet:Device
{
    public bool WithCase { get; set; }
    public int ScreenSize { get; set; } 
    
    public Tablet(string brand, string model, decimal price, bool withCase, int screenSize) : base(brand, model, price)
    {
        WithCase = withCase;
        ScreenSize = screenSize;
    }
    
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"with case: {WithCase}");
        Console.WriteLine($"screen size: {ScreenSize} inches");
    }
}