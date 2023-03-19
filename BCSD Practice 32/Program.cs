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
			int sum=0, i;

			for (i=0; i < 10 ; ++i)
			{
				if (i % 3 != 0)
				{
					Console.WriteLine(i);
					sum = sum + i;
				}
			}
			Console.WriteLine($"1~10중 3으로 나누어 떨어지지 않는 수의 합 : {sum}");
		}
	}
}
