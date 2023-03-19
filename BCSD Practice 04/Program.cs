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
			sbyte sbyteValue = 10; 
			int intValue = (int)sbyteValue;
			Console.WriteLine("sbyteValue : " + sbyteValue);
			Console.WriteLine("intValue : " + intValue);
			intValue = 130; 
			sbyteValue = (sbyte)intValue;
			Console.WriteLine("sbyteValue : " + sbyteValue);
			Console.WriteLine("intValue : " + intValue);
		}
	}
}
