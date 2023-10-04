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
		Console.Write("What is the temprature of H2O?: ");
		double temp = double.Parse(Console.ReadLine());
		string answer = "";
		if (temp >= 100.00){
		 answer = "gas";
		}
		else if (temp >0 && temp <100){
		answer = "liquid";
		}
		else if (temp <= 0) {
		answer = "solid";
		}
		Console.WriteLine("The H2O is in a {0} form.", answer);
	}
  }
}
