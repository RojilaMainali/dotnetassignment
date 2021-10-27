using System;

namespace dotnet_practice
{
public class Q6
{
    public static void q6()
    {
        int i,j;

        for (i = 1; i <= 7; i++)
        {
            for (j = 1; j <= 7; j++)
            {
                if(i>=j)
                {
                    Console.Write(j);

                }
                else
                {
                    Console.Write("*");

                }
            }
            Console.WriteLine();

        }
    }
}
}
