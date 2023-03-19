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
			int a = 3;
			Console.WriteLine($"{a} <<1= {a << 1}");
			Console.WriteLine($"{a} 2 = {a << 2}");
			Console.WriteLine($" {a} << 3 = {a << 3}");
			Console.WriteLine($" {a} << 4 = { a << 4}"); 
			a = 255;
			Console.WriteLine($"{a} >> 1 = {a >> 1}");
			Console.WriteLine($"{a} >> 2 = {a >> 2}");
			Console.WriteLine($"{a} >> 3 = {a >> 3}");
			Console.WriteLine($"{a} >> 4 {a >> 4}"); 
			a = -255;
			Console.WriteLine($" {a} >> 1 = {a >> 1}");
			Console.WriteLine($"{a} >> 2 = {a >> 2}");
			Console.WriteLine($"{a} >> 3 = {a >> 3}");
			Console.WriteLine($"{a} >> 4 = {a >> 4}");
			Console.WriteLine(Convert.ToString(a >> 4, 2));
			Console.WriteLine($"10 & 6 = {10 & 6}");
			Console.WriteLine($"10 I 6 = {10 | 6}");
			Console.WriteLine($"10 ^ 6 = {10 ^ 6}");
			Console.WriteLine($"~10 {~10}");
		}
	}
}
