using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many ★s would you like?");
        int count = int.Parse(Console.ReadLine());
        string stars = "";
        while (count > 0)
        {
            stars += "★";
            count--;
        }
        Console.WriteLine(stars);
    }
}
