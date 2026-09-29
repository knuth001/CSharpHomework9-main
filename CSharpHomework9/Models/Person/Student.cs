namespace CSharpHomework9.Models.Person;

public class Student : Person
{
   
    public string Email { get; set; }
    public string Password { get; set; }
    
    public Student(string firstName, string lastName, int age, string email, string password) : base(firstName, lastName, age)
    {
        Email = email;
        Password = password;
    }

    public override void Print()
    {   Console.ForegroundColor = ConsoleColor.Green;
        base.Print();
        Console.WriteLine($"email: {Email}");
        Console.WriteLine($"password: {Password}");
    }
}