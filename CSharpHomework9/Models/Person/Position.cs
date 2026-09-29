namespace CSharpHomework9.Models.Person;

public class Position:Person
{
    public decimal Salary { get; set; }
    public ulong PhoneNumber { get; set; }
    public string PositioninTeam { get; set; }
    
    public Position(string firstName, string lastName, int age, decimal salary, ulong phoneNumber, string positioninTeam) : base(firstName, lastName, age)
    {
        Salary = salary;
        PhoneNumber = phoneNumber;
        PositioninTeam = positioninTeam;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine($"PhoneNumber: {PhoneNumber}");
        Console.WriteLine($"PositioninTeam: {PositioninTeam}");
    }
}