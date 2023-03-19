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
			for (int index = 0; index < 10; ++index)
			{
				Console.WriteLine(index);
			}
			for (int x = 1; x < 10; ++x)
			{
				for (int y = 1; y < 10; ++y)
				{
					Console.WriteLine($"{x} x {y} = {x*y}");
				}
			}
		}
	}
}
