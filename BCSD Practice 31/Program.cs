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
			int result = 0; 
			int index = 1;
			while (index <= 100)
			{
				result += index;
				index++;
			}
			Console.WriteLine($"1부터 100까지의 합은 {result}");
		}
	}
}