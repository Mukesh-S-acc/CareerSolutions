using System;

class Program
{
    static void Main()
    {
        //1
        Console.WriteLine("Hello, C#");


        //2
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Welcome, " + name + "!");

        //3
        int age = 25;                
        string userName = "EY";   
        double height = 5.9;         

        Console.WriteLine("\nUser Info:");
        Console.WriteLine("Name   : " + userName);
        Console.WriteLine("Age    : " + age + " years");
        Console.WriteLine("Height : " + height + " feet");

     
    }
}
