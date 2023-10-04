using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
  public class Program
  {
    public static void Main(string[] args)
    {
		Console.Write("Please type the month(1-12)");
		var month = int.Parse(Console.ReadLine());
		if(new []{1, 3, 5, 7, 8, 10, 12}.Contains(month))
{
    Console.WriteLine("The month {0} has 31 days.", month);
}
		else if (new []{4, 6, 9, 11}.Contains(month))
		{
		Console.WriteLine("The month {0} has 30 days.", month);
		}
		else if (month == 2)
		{
		Console.WriteLine("The month {0} has either 28 days or 29 days.", month);
		}
		else{
		Console.WriteLine("You typed an invalid number.");
		}
	}
  }
}
