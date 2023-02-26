using OOP;
using System.Collections.Specialized;

class Program
{
    public static void Main(string[] args)
    {
    
        // implementing inheritance 
       
        Teacher teacher = new Teacher();
        Console.WriteLine("Inheritance");

        teacher.TeacherInfo("T-0001", "Mehedi Hasan");
        teacher.CourseDetails("cse101", "Computer Fundamental", 3);
        teacher.StudentInfo("LPL07600", "SOMAIYA JANNAT", 018765432);
        Console.WriteLine("\n");
        // encapsualtion
        Console.WriteLine("Encapsulation");
        LogIn log = new LogIn();
        log.SetPassWord("somaiya1234");
        
        Console.Write("Somaiya Jannat Password is : " );
        log.PrintPassWord();
        Console.WriteLine("\n");

        // abstraction
        Console.WriteLine("Abstraction");
        Guard guard= new Guard();
        Employee employee= new Employee();
        guard.MealsInfo();
        employee.MealsInfo();
        Console.WriteLine("\n");
        //polymorphism 
        // method overloading
        Console.WriteLine("Method Overloading");
        UserLogIn logIn = new UserLogIn();
        logIn.UserLogin("user", "user@123");
        logIn.UserLogin("user", "user@123", "employee");
        Console.WriteLine("\n");
        // method  Console.WriteLine("Inheritance");

        Console.WriteLine("Method Overriding");

        Admin admin = new Admin();
        admin.UserLogin("user", "user@123");
        Console.WriteLine("\n");
    }
}