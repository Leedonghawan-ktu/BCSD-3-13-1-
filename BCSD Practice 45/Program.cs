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
			string alphabet;
			for (i = 0; i < 26; ++i)
			{
				alphabet = "";
				alphabet += (char)(65 + i) + "\t";
				for (j = 0; j <= i; ++j)
				{
					alphabet += (char)(65 + j);
				}
				Console.WriteLine(alphabet);
			}
		}
	}
}