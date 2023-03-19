
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
			string str2 = "HELLO, WORLD";
			str2 = str2.Substring(7);
			Console.WriteLine(str2); 
			string position = "3, 5, 6"; 
			string[] str = position. Split(',');
			Console.WriteLine($"{str[0]}, {str[1]}, {str[2]}");
		}
	}
}