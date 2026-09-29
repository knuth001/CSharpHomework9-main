namespace CSharpHomework9.Models.Tech;

public class CameraMP:Device
{
    public int Ports  { get; set; }
    public int Quality { get; set; }
    
    public CameraMP(string brand, string model, decimal price, int ports, int quality) : base(brand, model, price)
    {
        Ports = ports;
        Quality = quality;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Port : {Ports}");
        Console.WriteLine($"Video quality : {Quality}K");
    }
}