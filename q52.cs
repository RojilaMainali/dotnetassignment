using System;

namespace dotnet_practice
{
public class Q52
{
    public static void q52()
    {
        int a,b;
        char operation;
        Console.Write("Enter first number:");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number");
        b = int.Parse(Console.ReadLine());
        Console.Write("Enter operation:");
        operation=char.Parse(Console.ReadLine());

        switch(operation)
         {
             case '+':
                Console.WriteLine($"Sum of {a} + {b} = {a + b}");
                break;

            case '-':  
                Console.WriteLine($"Difference of {a} - {b} = {a - b}");
                break;

             case '*':
                  Console.WriteLine($"Product of {a} * {b} = {a * b}");
                 break;

            case '/':  
                Console.WriteLine($"Quotient of {a} / {b} = {a / b}"); 
                break;    
            default:
                Console.WriteLine("Wrong Character");
                break;
            }    
     }   
 }   
  }      