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
			x /= 10; 
			switch (x) 
			{
				case 10:
					Console.WriteLine("학점 : A+"); 
					break;
				case 9:
					Console.WriteLine("학점 : A+"); 
					break;
				case 8:
					Console.WriteLine("학점 : B+"); 
					break;
				case 7:
					Console.WriteLine("학점 : C+"); 
					break;
				case 6:
					Console.WriteLine("학점 : D"); 
					break;
				default:
					Console.WriteLine("학점 : F"); 
					break; 
			}
		}
	}
}