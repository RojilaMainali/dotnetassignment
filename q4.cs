using System;

namespace dotnet_practice
{
public class Q4
{
    public static void q4()
    {
        int i, n, lar, elem;
        Console.Write ("Enter total number of elements: ");
        elem = int.Parse(Console.ReadLine()); 
        Console.Write ("Enter first number: ");
        n = int.Parse(Console.ReadLine()); 
        lar = n;
   
        for (i=1; i<= elem -1 ; i++)
        {
            Console.Write (" Enter another number: ");
            n = int.Parse(Console.ReadLine());
            if (n>lar)
            lar=n;
        }
     Console.WriteLine($"Largest number is:{lar}");
    }
 }
 }   