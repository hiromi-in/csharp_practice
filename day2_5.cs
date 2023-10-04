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
		Console.Write("Please type a word: ");
		var input = Console.ReadLine();
		if (input.Equals("Hello", StringComparison.OrdinalIgnoreCase)){
		Console.WriteLine("The input was 'Hello'");
		}
		else{
		Console.WriteLine("Please type 'Hello'");
		}
		
	}
  }
}
