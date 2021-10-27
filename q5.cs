using System;

namespace dotnet_practice
{
public class Q5
{
    public static void q5()
    {
        int a,b;
        char operation;
        Console.Write("Enter first number:");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number");
        b = int.Parse(Console.ReadLine());
        Console.Write("Enter operation:");
        operation=char.Parse(Console.ReadLine());
        if(operation== '+' )
        {
            Console.WriteLine($"Sum of {a} + {b} = {a + b}");
        }
        else if(operation== '-')
        {
             Console.WriteLine($"Difference of {a} - {b} = {a - b}");
    }
        else if( operation== '*')    
        { 
            Console.WriteLine($"Product of {a} * {b} = {a * b}");
        }
        else if( operation== '/') 
        {    
           Console.WriteLine($"Quotient of {a} / {b} = {a / b}");
         }
        else 
        { 
             Console.WriteLine("Wrong Character");
         }
    }
}    
}