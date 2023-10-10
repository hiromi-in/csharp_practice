using System;

internal class Program
{
    private static void Main(string[] args)
    {
         List<int> ints = new List<int>();

        for (int i = 1; i <= 5; i++) {
            Console.Write("What is the digit #{0}? ", i);
            ints.Add(int.Parse(Console.ReadLine()));
            }
        Console.WriteLine(String.Join(" ", ints));
        Console.Write("Max value: ");
        Console.WriteLine(ints.Max());
        Console.Write("Minimum value: ");
        Console.WriteLine(ints.Min());
    }   
}
