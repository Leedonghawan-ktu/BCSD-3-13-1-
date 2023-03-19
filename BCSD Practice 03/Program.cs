using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Learning
{
	class Program
	{
		static void Main()
		{
			object valueInt = 31;
			object valueFloat = 3.14159265358979f;
			object valueString = "객체지향 프로그래밍";
			object valueBool = false;
			Console.WriteLine("정수:" + valueInt);
			Console.WriteLine("실수:" + valueFloat);
			Console.WriteLine("문자열:" + valueString);
			Console.WriteLine("논리:" + valueBool);
		}
	}
}
