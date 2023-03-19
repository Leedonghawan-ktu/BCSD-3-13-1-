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
			string str = "HELLO, WORLD";
			Console.WriteLine(str); 
			str = str.Insert(0, "Hi~ ");
			Console.WriteLine($"Insert() - {str}"); 
			str = str.Remove(0, 4);
			Console.WriteLine($"Remove() - {str}"); 
			str = str.ToLower();
			Console.WriteLine($"ToLower() - {str}"); 
			str = str.ToUpper();
			Console.WriteLine($"ToUpper() - {str}");
			Console.WriteLine("== Trim ==");
			str = "   " + str + "   ";
			Console.WriteLine(str + "공백 체크"); 
			str = str.Trim();
			Console.WriteLine(str + "공백 체크");
			Console.WriteLine($"Before Replace : {str}"); 
			str = str.Replace("HELLO", "BYE");
			Console.WriteLine($"After Replace : {str}");
		}
	}
}
