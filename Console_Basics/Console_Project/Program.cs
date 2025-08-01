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
        double? height = null;
        var company_name = "EY";

        int var_test;

        bool flag = int.TryParse(company_name, out var_test);
        if (flag)
        {
            Console.Write("int value = " + var_test);
        }
        else
        {
            Console.Write("Parsing failed");
        }

            //Console.WriteLine("Parse value : " + flag);

        try
        {
            int test = Convert.ToInt32(company_name);

        }
        catch (FormatException ex) { 
           Console.WriteLine(ex.Message);
        }

        //Console.Write("test = " + test);

        //Console.WriteLine("\nUser Info:");
        //Console.WriteLine("Name   : " + userName);
        //Console.WriteLine("Age    : " + age + " years");
        //Console.WriteLine("Height : " + height + " feet");

        

     
    }
}
