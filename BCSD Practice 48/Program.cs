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
			int count, i, j ;
			string Alphabet;
			for (i = 0; i < 26; ++i)
			{
				Alphabet = "";
				Alphabet += (char)(65 + i) + "\t";
				//온쪽에 출력되는 알파벳을 배열에 입력받는다.
				count = 0;
				for (j = i; j < 26; ++j)
				{
					Alphabet += (char)(65 + count / 3);
					//같은 알파벳을 3번씩 출력하기 위해 count를 3으로 나눈 몺의 값+65의 값을 아스키코트로 알파벳으로 변환한다.
					count++;
				}
				Console.WriteLine(Alphabet);
			}
		}
	}
}