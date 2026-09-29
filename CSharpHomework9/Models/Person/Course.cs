namespace CSharpHomework9.Models.Person;

public class Course:Person
{
    
    public  int CourseId { get; set; }
    public int LessonsinWeek { get; set; }
    
    public Course(string firstName, string lastName, int age, int courseId, int lessonsinWeek) : base(firstName, lastName, age)
    {
        CourseId = courseId;
        LessonsinWeek = lessonsinWeek;
    }

    public override void Print()
    {   
        base.Print();
        Console.WriteLine($"course: {CourseId}");
        Console.WriteLine($"lessons: {LessonsinWeek}");
    }
}