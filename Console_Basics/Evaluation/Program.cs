using System;
using System.Text;

class Program
{

    public static void Main()
    {
        //DateTime dobj = DateTime.Now;
        ////Console.Write("obj = "+dobj.AddMinutes(90) );

        //StringBuilder s = new StringBuilder(Console.ReadLine());
        //s.Append("Hi");

        //Console.WriteLine(s);

        Student student = new Student();
        Student obj2 = new Student(18);

        //string firstName = Console.ReadLine();
        //string lastName = Console.ReadLine();

        student.firstName = "Ey";
        student.lastName = " Gds";

        //student.Display(firstName, lastName);

        int[] arr = new int[5];

        arr[0] = 100; arr[1] = 200; arr[2] = 300; arr[3] = 400; arr[4] = 500;

        int[] arr2 = new int[] { 100, 200, 300, 400, 500 };

        for (int i = 0; i < arr2.Length; i++) { 
            Console.Write(arr2[i]);
        }
        Console.WriteLine();

        foreach(int i in arr)
        {
            Console.Write(i);
        }
        //Base class Animal -> speak()
        //Derived Dog->override speak()

        //Dog animal = new Animal();

        Animal a = new Dog();

        a.speak();

        



    }
}

class Student
{
    readonly int maxCount = 100;
    const int maxSubjects = 10;


    public Student() {

        maxCount = 200;
        //maxSubjects = 30;

    }
    public Student(int age )
    {
        Console.WriteLine("age = " + age);
    }

    private string first_Name;
    private string last_Name;

    public int age { get; set; }

 
    public string firstName { 
        get 
            { return first_Name; }
        set
        {
            first_Name = value;
        }
    }

    public string lastName { 
        get {
            return last_Name;
        }
        set
        {
            last_Name = value;
        }
    }

    public void Display(string fName, string lName)
    {
        firstName = fName;
        lastName = lName;

        Console.WriteLine("First name : " + first_Name + ". Last name : " + last_Name);
    }

    public int Addition(int x , int y)
    {
        int sum = x + y;
        //Console.WriteLine("Sum = " + sum);
        return sum;
    }

    public bool ageCheck(int Age)
    {
        age = Age;
        if (age > 18) return true;

        return false;

    }




}


class Animal
{
    public virtual void speak()
    {
        Console.WriteLine("Animal speak");
    }
}

class Dog : Animal
{
    public override void speak()
    {
        //base.speak()
        Console.WriteLine("Dog is speaking");
    }
}