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
			int a = 10;
			Console.WriteLine($"a = 10 : {a}"); 
			a += 10;
			Console.WriteLine($"a += 10 : 결과 값 {a}");
			Console.WriteLine($"a -= 9 : 결과 값 {a -= 9}");
			Console.WriteLine($"a = 8 : 결과 값 {a = 8}");
			Console.WriteLine($"a /= 7 : 결과 값 {a /= 7}");
			Console.WriteLine($"a %= 6 : 결과 값 {a %= 6}");
			Console.WriteLine($"a &= 5 : 결과 값 {a &= 5}");
			Console.WriteLine($"a I= 4 : 결과 값 {a |= 4}");
			Console.WriteLine($"a ^= 3 : 결과 값 {a ^= 3}");
			Console.WriteLine($"a <<= 2 : 결과 값 {a <<= 2}");
			Console.WriteLine($"a >>= 1 : 결과 값 {a >>= 1}");
		}
	}
}
