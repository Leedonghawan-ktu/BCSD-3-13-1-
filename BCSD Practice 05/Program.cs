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
			sbyte sbyteValue = 31; 
			byte byteValue = (byte)sbyteValue;
			Console.WriteLine("sbyteValue : " + sbyteValue);
			Console.WriteLine("byteValue : " + byteValue); 
			sbyteValue = -31; 
			byteValue = (byte)sbyteValue;
			Console.WriteLine("sbyteValue : " + sbyteValue);
			Console.WriteLine("byteValue : " + byteValue);
			byteValue = 200; 
			sbyteValue = (sbyte)byteValue;
			Console.WriteLine("sbyteValue : " + sbyteValue);
			Console.WriteLine("byteValue : " + byteValue); 
			
		}
	}
}
