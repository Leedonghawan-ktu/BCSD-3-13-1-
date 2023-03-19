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
			int intValue = 10; 
			float floatValue = 12.3456f; 
			string stringValue = "33";
			Console.WriteLine("intValue : " + intValue);
			Console.WriteLine("floatValue : " + floatValue);
			Console.WriteLine("stringValue : " + stringValue);
			intValue = int.Parse(stringValue); 
			stringValue = "33.4567"; 
			floatValue = float.Parse(stringValue);
			Console.WriteLine("intValue : " + intValue);
			Console.WriteLine("floatValue : " + floatValue);
			Console.WriteLine("stringValue : " + stringValue);
		}
	}
}