using System;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("The 9X9 chart");
            for (int i = 1; i <= 9; i++)
        {
            for (int j=1; j <=9; j++)
            {
                Console.Write("{0}x{1}={2, 2:d} ", i, j, i*j);
            }
            Console.WriteLine();
        }
    }   
}
