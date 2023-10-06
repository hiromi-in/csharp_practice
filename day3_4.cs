using System;

internal class Program
{
    private static void Main(string[] args)
    {

        Random rnd = new Random();
        int biggest = 0;
        int smallest = 100;

        for (int i = 1; i <= 10; i++)
        {
            int num = rnd.Next(1, 101);
            Console.Write(num + " ");
            if (biggest < num)
            {
                biggest = num;
            }
            else if (smallest > num)
            {
                smallest = num;
            }
        }
        Console.WriteLine("\nThe biggest number: {0}", biggest);
        Console.WriteLine("The smallest number: {0}", smallest);
    }   
}
