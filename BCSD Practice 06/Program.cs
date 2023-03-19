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
			float floatValue = 69.6875f; 
			double doubleValue = (double)floatValue;
			Console.WriteLine("floatValue : " + floatValue);
			Console.WriteLine("doubleValue : " + doubleValue); 
			floatValue = 0.1f; 
			doubleValue = (double)floatValue;
			Console.WriteLine("floatValue : "+ floatValue);
			Console.WriteLine("doubleValue : " + doubleValue);
		}
	}
}
