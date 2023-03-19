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
			int a = 5 + 6; 
			int b = a - 3; 
			int c = a * b; 
			int d = c / 8; 
			int e = d % 4;
			Console.WriteLine($"{a} = 5 + 6");
			Console.WriteLine($"{b} = {a} - 3");
			Console.WriteLine($" {c} = {a} * {b}");
			Console.WriteLine($"{d} = {c} / 8");
			Console.WriteLine($" {e} = {d} % 4");
		}
	}
}
