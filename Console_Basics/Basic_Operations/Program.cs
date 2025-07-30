using System;

class Program
{
    static void Main()
    {
       // 1.
        Console.Write("Enter first number to add: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number to add: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine("Sum = " + sum);

        Console.Write("Enter first number to multiply : ");
        int m1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number to multiply : ");
        int m2 = int.Parse(Console.ReadLine());
        int product = m1 * m2;
        Console.WriteLine("Product = " + product);

        //2.

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote ");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote ");
        }

        Console.Write("Enter a number to check value :  ");
        int checkNum = int.Parse(Console.ReadLine());
        if (checkNum > 0)
        {
            Console.WriteLine("Number is Positive");
        }
        else if (checkNum < 0)
        {
            Console.WriteLine("Number is Negative");
        }
        else
        {
            Console.WriteLine("Number is Zero");
        }

        Console.Write("Enter a number to check even or odd : ");
        int evenOddNum = int.Parse(Console.ReadLine());
        if (evenOddNum % 2 == 0)
        {
            Console.WriteLine("Number is Even");
        }
        else
        {
            Console.WriteLine("Number is Odd");
        }

        // 3
        Console.WriteLine("Numbers from 1 to 10 , using loopings ");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        int totalSum = 0;
        for (int i = 1; i <= 100; i++)
        {
            totalSum += i;
        } 
        Console.WriteLine("Sum from 1 to 100  = " + totalSum);

        Console.WriteLine("Even numbers between 1 and 20 : ");

        int j = 2;
        while (j <= 20)
        {
            Console.Write(j + " ");
            j += 2;
        }

    }
}
