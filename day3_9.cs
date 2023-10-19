using System;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] int_list = new int[10];
        List<int> one_digit = new List<int>();
        List<int> teens = new List<int>();
        List<int> twenties = new List<int>();
        List<int> thirties = new List<int>();
        List<int> forties = new List<int>();
        List<int> fifties = new List<int>();
        List<int> sixties = new List<int>();
        List<int> seventies = new List<int>();
        List<int> eighties = new List<int>();
        List<int> nineties = new List<int>();
        
        for (int i = 0; i < 10; i++) {
            int_list[i] = rnd.Next(1,100);
            Console.Write("{0} ", int_list[i]);
            if (int_list[i] < 10 && int_list[i] > 0) {
                one_digit.Add(int_list[i]);
            }
            if (int_list[i] < 20 && int_list[i] >= 10)
            {
                teens.Add(int_list[i]);
            }
            if (int_list[i] < 30 && int_list[i] >= 20)
            {
                twenties.Add(int_list[i]);
            }
            if (int_list[i] < 40 && int_list[i] >= 30)
            {
                thirties.Add(int_list[i]);
            }
            if (int_list[i] < 50 && int_list[i] >= 40)
            {
                forties.Add(int_list[i]);
            }
            if (int_list[i] < 60 && int_list[i] >= 50)
            {
                fifties.Add(int_list[i]);
            }
            if (int_list[i] < 70 && int_list[i] >= 60)
            {
                sixties.Add(int_list[i]);
            }
            if (int_list[i] < 80 && int_list[i] >= 70)
            {
                seventies.Add(int_list[i]);
            }
            if (int_list[i] < 90 && int_list[i] >= 80)
            {
                eighties.Add(int_list[i]);
            }
            if (int_list[i] < 100 && int_list[i] >= 90)
            {
                nineties.Add(int_list[i]);
            }
            int_list[i] = 100;
        }

        Console.WriteLine("");
        Console.WriteLine("0~9: {0}", String.Join(" ", one_digit));
        Console.WriteLine("10~19: {0}", String.Join(" ", teens));
        Console.WriteLine("20~29: {0}", String.Join(" ", twenties));
        Console.WriteLine("30~39: {0}", String.Join(" ", thirties));
        Console.WriteLine("40~49: {0}", String.Join(" ", forties));
        Console.WriteLine("50~59: {0}", String.Join(" ", fifties));
        Console.WriteLine("60~69: {0}", String.Join(" ", sixties));
        Console.WriteLine("70~79: {0}", String.Join(" ", seventies));
        Console.WriteLine("80~89: {0}", String.Join(" ", eighties));
        Console.WriteLine("90~99: {0}", String.Join(" ", nineties));

    }   
}

