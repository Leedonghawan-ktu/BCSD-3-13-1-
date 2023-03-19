using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
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
			char alphabet;
			string letter;
			for (i = 0; i < 26; ++i)
			{
				alphabet = 'A';
				letter = "";
				for (j = 0; j < i; ++j)
				{
					letter += "  ";
					//알파벳 앞에 들어가는 공백을 입력받는 반복문
				}
				for (j = 0; j <= i; ++j)
				{
					letter += alphabet;
					alphabet++;
					//공백 뒤에 들어가는 알파벳을 입력받는 반복문
				}
				Console.WriteLine(letter);
			}
		}
	}
}