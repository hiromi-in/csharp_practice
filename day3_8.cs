using System;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] int_list = new int[10];
        List<int> new_li = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            int_list[i] = (rnd.Next(1, 101));
            
        }
        Console.WriteLine(String.Join(" ", int_list));
        
        for (int i = 0; i < 10; i++)
        {
         int max = 0;
            for (int j = 0; j < int_list.Length; j++)
            {
                if (int_list[j] > max)
                {
                    max = int_list[j];

                }
            }
        new_li.Add(max);
            for (int k = 0; k < int_list.Length; k++)
            {
                if (max == int_list[k])
                {
                    int_list[k] = -1;
                    break;
                }
            }
        }
        Console.WriteLine(String.Join(" ", new_li));
    }
}
