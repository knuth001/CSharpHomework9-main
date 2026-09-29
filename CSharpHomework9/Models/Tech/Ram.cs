namespace CSharpHomework9.Models.Tech;

public class Ram:Device
{
    
    public string Name { get; set; }
    public int Memory { get; set; }
    public int Socket { get; set; }
    public int Amount { get; set; }
    
    public Ram(string brand, string model, decimal price, string name, int memory, int socket, int amount) : base(brand, model, price)
    {
        Name = name;
        Memory = memory;
        Socket = socket;
        Amount = amount;
    }

    public override void PrintInfo()
    {   base.PrintInfo();
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Memory: {Memory}");
        Console.WriteLine($"You need: {Socket}free slot for it");
        Console.WriteLine($"Amount: {Amount}");
        
    }
}