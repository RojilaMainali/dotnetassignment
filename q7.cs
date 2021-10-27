using System;

namespace dotnet_practice
{
public class Q7
{
    public static void q7()
    {
        float firstTermScore, secondTermScore, finalScore,totalscore,percentage;
        Console.Write("Enter score of first term:");
        firstTermScore= float.Parse(Console.ReadLine());
        Console.Write("Enter score of second term:");
        secondTermScore= float.Parse(Console.ReadLine());
        Console.Write("Enter score of third term:");
        finalScore= float.Parse(Console.ReadLine());

        totalscore=firstTermScore+ secondTermScore+ finalScore;
        percentage= (totalscore/300)*100;

        string output = $"Your percentage is: {percentage}%";

        // Show the output to user 
        Console.WriteLine(output);

        if(percentage >=90 )
        {
            Console.WriteLine("You got grade  A");
        } 
        else if(percentage >=70 && percentage<90 )
        {
            Console.WriteLine("You got grade  B");
        } 
        else if(percentage >=50 && percentage<70 )
        {
            Console.WriteLine("You got grade  C");
        } 
        else if(percentage >=35 && percentage<50 )
        {
            Console.WriteLine("You got grade  E");
        } 
        else 
        {
            Console.WriteLine("You got grade  F");
        } 
     }
 }
  }



