namespace CSharpHomework9.Models.Person;

public class Teacher:Person
{
    public decimal Salary { get; set; }
    public int experiance { get; set; }
    
    public Teacher(string firstName, string lastName, int age, decimal salary, int experiance) : base(firstName, lastName, age)
    {
        Salary = salary;
        this.experiance = experiance;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine($"Experience: {experiance}");
    }
}