namespace CSharpHomework9.Models.Person;

public class Administrator:Person
{
    public string Team { get; set; }
    public int Experiance { get; set; }
    
    public Administrator(string firstName, string lastName, int age, string team, int experiance) : base(firstName, lastName, age)
    {
        Team = team;
        Experiance = experiance;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Team : {Team}");
        Console.WriteLine($"Experience Years: {Experiance}");
    }
}