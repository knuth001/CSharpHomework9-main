namespace CSharpHomework9.Models.Person;

public class Subject:Person
{
    public string FullName { get; set; }
    public decimal Payment { get; set; }
    
    public Subject(string firstName, string lastName, int age, string fullName, decimal payment) : base(firstName, lastName, age)
    {
        FullName = fullName;
        Payment = payment;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"FullName: {FullName}");
        Console.WriteLine($"Payment: {Payment}");
    }
}