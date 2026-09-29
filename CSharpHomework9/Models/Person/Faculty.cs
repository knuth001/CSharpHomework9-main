namespace CSharpHomework9.Models.Person;

public class Faculty:Student
{
   

    public int PeopleAmount { get; set; }
    public decimal Pay { get; set; }
    
    public Faculty(string firstName, string lastName, int age, string email, string password, int peopleAmount, decimal pay) : base(firstName, lastName, age, email, password)
    {
        PeopleAmount = peopleAmount;
        Pay = pay;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Studentebis raodenoba : {PeopleAmount}");
        Console.WriteLine($"wliuri gadasaxadi : {Pay}");

    }

   
  
}