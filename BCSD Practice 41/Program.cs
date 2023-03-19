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
			int i,j;
			string letter = "";
			for (i = 1; i <= 26; ++i)
			{
				letter = "";
				for (j = 1; j < i; ++j)
				{
					letter += (char)(64 + j);
				}

				Console.WriteLine(letter);
			}
		}
	}
}