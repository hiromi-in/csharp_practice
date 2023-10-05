using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many ★s would you like?");
        int count = int.Parse(Console.ReadLine());
        string stars = "";
        for (int i = 1; i <= count; i++)
        {
            stars += "★";
        }
        Console.WriteLine(stars);
    }
}
