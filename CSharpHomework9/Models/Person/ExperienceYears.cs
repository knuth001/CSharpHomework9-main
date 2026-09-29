namespace CSharpHomework9.Models.Person;

public class ExperienceYears:Person
{
    public int ExperianceYears { get; set; }
    
    public ExperienceYears(string firstName, string lastName, int age, int experianceYears) : base(firstName, lastName, age)
    {
        ExperianceYears = experianceYears;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Experience Years: {ExperianceYears}");
    }
}