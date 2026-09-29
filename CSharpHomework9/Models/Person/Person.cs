namespace CSharpHomework9.Models.Person;

public class Person
{
    public  string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    
    
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public virtual void Print()
    {   
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("================");
        Console.WriteLine($"{FirstName} {LastName}");
        Console.WriteLine($"Age: {Age}");
    }
    
}