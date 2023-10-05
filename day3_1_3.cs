using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many ★s would you like?");
        int count = int.Parse(Console.ReadLine());
        string stars = "";
        do
        {
            stars += "★";
            count--;
        }
        while (count > 0);
        Console.WriteLine(stars);
    }
}
