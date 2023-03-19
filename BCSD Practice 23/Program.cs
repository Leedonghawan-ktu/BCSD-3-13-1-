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
			bool result = false;
			int x = 5, y = 2;
			result = x > 2 && y |= 5;
			Console.WriteLine($" {x} > 2 & {y} != 5 = {result}");
			result = x < 4 || y == 3;
			Console.WriteLine($"{x} < 4 II {y} == 3 = {result}");
			Console.WriteLine(result); 
			result = !result;
			Console.WriteLine(result);
			int hp = -10; 
			hp = hp < 0 ? 0 : hp;
			Console.WriteLine("체력 : " + hp);
		}
	}
}