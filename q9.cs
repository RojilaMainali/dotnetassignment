using System;

namespace dotnet_practice
{
public class Q9
{
    public static void q9()
    {
        Console.WriteLine("Enter number between 1 and 6:");
        int num =int.Parse (Console.ReadLine());

        Random rnd = new Random();
        int randomnum  = rnd.Next(1, 6);  

        if(num==randomnum)
        {
        Console.WriteLine("You Won");
        }

        else
        {
        Console.WriteLine("You Lose");
        }
}

}
}        


