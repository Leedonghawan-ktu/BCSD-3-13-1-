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
			if (x >= 90)
			{
				Console.WriteLine("학점 : A+");
			}
			else if (x >= 80)
			{
				Console.WriteLine("학점 : B+");
			}
			else if (x >= 70)
			{
				Console.WriteLine("학짐 : C+");
			}
			else if (x >= 60)
			{
				Console.WriteLine("학점 : D");
			}
			else
			{
				Console.WriteLine("학점 : F");
			}
		}
	}
}