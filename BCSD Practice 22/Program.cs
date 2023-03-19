using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Learning
{
	class Program
	{
		static void Main()
		{
			int x = 5, y = 2;
			Console.WriteLine($"{x} > {y} = {x > y}");
			Console.WriteLine($"{x} < {y} = {x < y}");
			Console.WriteLine($" {x} >= {y} = {x >= y}");
			Console.WriteLine($" {x} <= {y} = {x <= y}");
			Console.WriteLine($" {x} = {y} = {x == y}");
			Console.WriteLine($"{x} I= {y} = {x != y}");
		}
	}
}
