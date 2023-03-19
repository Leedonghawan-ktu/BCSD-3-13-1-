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
			float floatValue = 0.9f; 
			int intValue = (int)floatValue;
			Console.WriteLine("floatValue : " + floatValue);
			Console.WriteLine("intValue : " + intValue); 
			floatValue = 1.1f; 
			intValue = (int)floatValue;
			Console.WriteLine("floatValue : " + floatValue);
			Console.WriteLine("intValue : " + intValue);
		}
	}
}
