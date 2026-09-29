using CSharpHomework9.Models.Bank_Account;
using  CSharpHomework9.Models.Person;
using CSharpHomework9.Models.Tech;

//task 1
Person person = new Person("nika", "nikoladze", 18);
person.Print();
Console.WriteLine("\n");
Student student = new Student("gio","giorgadze",22,"giorgi@gmail.com","gio123");
student.Print();
Console.WriteLine("\n");

Faculty faculty = new Faculty("webdev" ,"web development",3,"educate@gmail.com","webdev123",
    250,2850); 
faculty.Print();
Console.WriteLine("\n");

Course course = new Course("C# course","backend dev",2,3,2);
course.Print();
Console.WriteLine("\n");

Teacher teacher = new Teacher("Anders","Hejlsberg",60, 5000,30);
teacher.Print();
Console.WriteLine("\n");

Subject subject = new Subject("programming","developerment",2,"Web Development + Game Development",360);
subject.Print();
Console.WriteLine("\n");

ExperienceYears experience = new ExperienceYears("beso", "lomidze", 24, 5);
experience.Print();
Console.WriteLine("\n");

Administrator administrator = new Administrator("uncle", "BoB", 55, "Clean Code", 30);
administrator.Print();
Console.WriteLine("\n");

Position position = new Position("Nika","lekishvili",17,2000,511123321,"Software Engineer");
position.Print();
Console.WriteLine("\n");

//task 2

Device device = new Device("Nvidia", "RTX 5060", 300);
device.PrintInfo();

Laptop laptop = new Laptop("Lenovo", "Thinkpad", 1000, 1, 32);
laptop.PrintInfo();

Ram ram = new Ram("Colorful", "Battle-AX 3200Mhz", 120, "Colorful Battle-AX 3200Mhz 16GB DDR4",
    16, 2, 2); 
ram.PrintInfo();   

Smartphone smartphone = new Smartphone("Apple","Iphone 17",1500,120,5000);
smartphone.PrintInfo();

CameraMP camera = new CameraMP("Canon","EOS R5",3000,6,8);
camera.PrintInfo();

Tablet tablet = new Tablet("Samsung","SM-X736 Galaxy Tab S11", 830,true,11);
tablet.PrintInfo();

ScreenSize screen = new ScreenSize("Apple","Macbook neo",500,14);
screen.PrintInfo();

//task 3 

//BankAccount bankAccount = new BankAccount("51112341","nika",2500);
//Console.WriteLine(bankAccount.CalculateInterest(0));

SavingsAccount savingsAccount = new SavingsAccount("51112341","nika",2500);
Console.WriteLine(savingsAccount.CalculateInterest(5));

BusinessAccount businessAccount = new BusinessAccount("51112341","nika",2500);
Console.WriteLine(businessAccount.CalculateInterest(3));

StudentAccount studentAccount = new StudentAccount("51112341","nika",2500);
Console.WriteLine(studentAccount.CalculateInterest(1));