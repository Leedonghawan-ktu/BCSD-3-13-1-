using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Learning
{
	class Program
	{
		static void Main()
		{
			int minutes = 1; 
			int seconds = 15;
			Console.WriteLine(string.Format("{0, -10:D5}", minutes,":", seconds)); 
			Console.WriteLine($" {minutes} : {seconds}");
			Console.WriteLine(string.Format("{0}{1}{2}", minutes,":", seconds));
			Console.WriteLine($" {minutes, -10:D5}");
		}
	}
}