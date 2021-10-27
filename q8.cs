using System;

namespace dotnet_practice
{
public class Q8
{
    public static void q8()
    {

        int  a=10;
        float b=13.5F;
        string c="50";
        float sum;

        string output = $"The values of a, b and c are {a}, {b} and {c} respectively";

        // Show the output to user 
        Console.WriteLine(output);

        sum= a+b+float.Parse(c);
        
        Console.WriteLine($"The sum is  {sum}");

        string str = String.Concat(a,b,c);
        Console.WriteLine($"Concatenated value is:{str}");
        
    }
}
}