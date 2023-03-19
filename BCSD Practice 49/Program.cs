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
			int i, j, count;
			string Alphabet;
			for (i = 0; i < 26; ++i)
			{
				Alphabet = "";
				Alphabet += (char)(65 + i) + "\t";
				count = 0;
				for (j = i; j < 26; ++j)
				{
					Alphabet += (char)(65 + count / 3);
					count++;
				}
				Alphabet += "  ";
				for (j = i; j < 26; ++j)
				{
					Alphabet += (char)(65 + j);
				}
				Console.WriteLine(Alphabet);
			}
		}
	}
}
