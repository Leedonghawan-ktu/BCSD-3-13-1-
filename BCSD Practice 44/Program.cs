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
			string letter;
			for (i = 0; i < 26; ++i)
			{
				letter = "";
				letter += (char)(65 + i) + "\t";
				for (j = 0; j < i; ++j)
				{
					//알파벳 앞에 들어갈 공백을 입력받는 반복문이다.
					letter += "  ";
				}

				for (j = i; j < 26; ++j)
				{
					//공백 뒤에 들어갈 알파벳을 입력받는 반복문이다.
					letter += (char)(65 + j);
				}
				Console.WriteLine(letter);
			}
		}
	}
}