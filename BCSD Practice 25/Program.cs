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
			int x = 10;
			if (x % 2 == 0) 
			{
				Console.WriteLine("x는 짝수다"); 
			}
			if (x > 5 && x < 10)
			{
				Console.WriteLine("x는 5보다 크고 10 보다 작다");
			}
			if (x > 5)
			{
				if (x < 10)
				{
					Console.WriteLine("x는 5보다 크고 10보다 작다");
				}
			}
			Console.WriteLine($"x의 값은 {x}");
		}
	}
}