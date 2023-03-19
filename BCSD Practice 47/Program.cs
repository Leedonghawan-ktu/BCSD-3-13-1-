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
			string alphabet ;
			for (i = 0; i < 26; ++i)
			{
				alphabet = "";
				alphabet += (char)(65 + i) + "\t";
				//왼쪽에 들어갈 알파벳을 문자열에 순차적으로 입력받는다.
				for (j = 0; j <= i; ++j)
				{
					alphabet += "  ";
				}
				for (j = i; j < 26 - i; ++j)
				{
					alphabet += (char)(65 + j);
				}
				Console.WriteLine(alphabet);
			}
		}
	}
}
