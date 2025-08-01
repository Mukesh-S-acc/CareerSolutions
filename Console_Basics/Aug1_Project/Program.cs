using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


class Program
{

    //1.	Ask the user to input their birthdate.Then calculate and display their current age in years.
    //2.	Ask the user to enter a date, and then a number of days.Add that number of days to the date and display the new date.
    //3.	Take a date input from the user and display the day of the week for that date.
    //4.	Ask the user to enter a number n, then input n words. Use StringBuilder to build a comma-separated string of those words and display it.
    //5.	Ask the user to input a sentence and two words: one to find and one to replace it with.Use StringBuilder to replace the word.
    //a.For eg Input: "I love cats", find: "cats", replace with: "dogs"
    //b.Output "I love dogs"
    //6.	Create a class Student with a static field:
    //a.  static int totalStudents
    //b.Each time a new Student is created, increment totalStudents.Display it in Main() after creating a few students.
    //7.	Create a class called Visitor.Every time a new Visitor object is created, increment a static counter field TotalVisitors.
    //Display the total visitors after creating 5 objects.
    //a.Try to do the same via const and readonly and understand the difference

    public static void Main()
    {

        //1.

        Console.Write("Enter your birthdate in (dd-mm-yyyy): ");

        DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

        int age = DateTime.Now.Year - birthDate.Year;

        //Console.WriteLine(DateTime.Now.Date + "    - " + birthDate.DayOfYear);

        if(DateTime.Now.DayOfYear < birthDate.DayOfYear)
        {
            age--;
        }

        Console.WriteLine("Your age is: " + age);


        //2.

        Console.WriteLine("Enter a date: ");
        DateTime ipDate = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Enter no.of days to add: ");
        int daysToAdd = int.Parse(Console.ReadLine());

        Console.WriteLine("New date after adding days: " + ipDate.AddDays(daysToAdd).ToShortDateString());

        //3. 
        Console.WriteLine("Enter a date to know the day of the week (dd-mm-yyyy): ");
        DateTime dayCheck = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Day of the week: " + dayCheck.DayOfWeek);


        //4.

        Console.WriteLine("Enter the number of words: ");
        int n = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a word " + (i + 1) + ": ");
            string word = Console.ReadLine();
            sb.Append(word);
            if (i < n - 1) { 
                
                sb.Append(", ");
             }
        }
        Console.WriteLine("Comma-separated string: " + sb.ToString());


        //5. replace a word in string 

        Console.WriteLine("Enter a sentence: ");
        string sentence = Console.ReadLine();
        Console.WriteLine("Enter the word to find: ");
        string find = Console.ReadLine();
        Console.WriteLine("Enter the word to replace it with: ");
        string replace = Console.ReadLine();

        StringBuilder string_Replace = new StringBuilder(sentence);
        string_Replace.Replace(find, replace);
        Console.WriteLine("Updated sentence: " + string_Replace.ToString());



        //6.

        Console.WriteLine("Creating students...");
        Student s1 = new Student("John");
        Student s2 = new Student("Alice");
        Student s3 = new Student("Bob");
        Console.WriteLine("Total students created: " + Student.totalStudents);


        //7.
        Console.WriteLine("\nCreating visitors...");
        Visitor v1 = new Visitor("V1");
        Visitor v2 = new Visitor("V2");
        Visitor v3 = new Visitor("V3");
        Visitor v4 = new Visitor("V4");
        Visitor v5 = new Visitor("V5");
        Console.WriteLine("Total visitors created: " + Visitor.totalVisitors);

        Console.WriteLine("Const vs ReadOnly:");
        Console.WriteLine("Company name (const): " + Visitor.Company);
        Console.WriteLine("Branch (readonly): " + v1.Branch);
    }





   

}


class Student
{
    public string Name;
    public static int totalStudents = 0;

    public Student(string name)
    {
        Name = name;
        totalStudents += 1;
    }
}

class Visitor
{
    public string VisitorName;
    public static int totalVisitors = 0;

    public const string Company = "Companyname";
    public readonly string Branch;

    public Visitor(string name)
    {
        VisitorName = name;
        totalVisitors += 1;
        Branch = "Main branch";
    }
}