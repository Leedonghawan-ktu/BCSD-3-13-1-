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
			int minutes = 1; 
			int seconds = 15;
			Console.WriteLine(string.Format("기본 : {@}{1}{2}", minutes, ":", seconds));
			Console.WriteLine(string.Format("왼쪽 맞춤 : {@, -5}{1}{2}", minutes, ":", seconds));
			Console.WriteLine(string.Format("오른쪽 맞춤 : {0, 5}{1}{2}", minutes, ":", seconds));
			Console.WriteLine(string.Format("10진수 서식화 : {@:D}", 123));
			Console.WriteLine(string.Format("10진수 서식화(5자리) : {@:D5}", 123));
			Console.WriteLine(string.Format("16진수 서식화 : {@:X}", 0x00));
			Console.WriteLine(string.Format("16진수 서식화(10자리) : {@:X10}", 0x00));
			Console.WriteLine(string.Format("고정소수점 서식화 : {@:F}", 1.23));
			Console.WriteLine(string.Format("고정소수점 서식화(소수점 1자리) : {@:F1}", 1.23));
			Console.WriteLine(string.Format("콤마로 구분 : {@:N}", 1234567890));
			Console.WriteLine(string.Format("지수 {@:E}", 1234567890));
			DateTime dt = new DateTime(2020, 2, 22, 13, 40, 0); 
			string str = dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)");
			Console.WriteLine(str);
            str = dt.ToString("yyyy-MM-dd HH:mm:ss (ddd)");
			Console.WriteLine(str); 
		}
	}
}