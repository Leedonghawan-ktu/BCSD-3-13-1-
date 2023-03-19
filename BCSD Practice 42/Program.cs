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
			int i, j;
			char alphabet = 'A';
			string letter ;
			for (i = 0; i < 26; ++i)
			{
				letter = "";
				for (j = 0; j <= i; ++j)
				{
					letter += alphabet;
				}
				Console.WriteLine(letter);
				alphabet++;
			}
		}
	}
}
