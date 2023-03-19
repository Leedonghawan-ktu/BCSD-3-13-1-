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
			string stringValue = "초기화"; 
			int intValue = 33; 
			float floatValue = 12.3456f;
			Console.WriteLine("stringValue : " + stringValue);
			stringValue = intValue. ToString();
			Console.WriteLine("stringValue : " + stringValue);
			stringValue = floatValue.ToString();
			Console.WriteLine("stringValue : " + stringValue);
		}
	}
}