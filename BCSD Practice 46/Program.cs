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
				//왼족에 출력할 알파벳을 입력받는다.
				for (j = 0; j < 26; ++j)
				{
					alphabet += (char)(65 + j);
					if (i == j)
					//현재 왼쪽에 있는 알파벳과 오른ㄴ쪽에 있는 알파벳이 동일한지 확인
					{
						alphabet += (char)(65 + j);
						//동일할 경우 알파벳을 한번더 입력받는다.
					}
				}
				Console.WriteLine(alphabet);
			}
		}
	}
}