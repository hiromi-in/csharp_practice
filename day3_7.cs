using System;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] int_list = new int[10];
        List<int> odds = new List<int>();
        List<int> evens = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            int_list[i] = rnd.Next(1, 101);
            if (int_list[i] % 2 == 0 || int_list[i] == 0)
            {
                evens.Add(int_list[i]);
            }
            else if (int_list[i] == 1 || int_list[i] % 2 != 0)
            {
                odds.Add(int_list[i]);
            }
        }
        Console.WriteLine(String.Join(" ", int_list));
        Console.WriteLine("Odd numbers: " + String.Join(" ", odds));
        Console.WriteLine("Even numbers: " + String.Join(" ", evens));

    }
}
