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
			sbyte byteValue = -128; 
		    byte ubyteValue = 255; 
		    short shortValue = -32768; 
		    ushort ushortValue = 65535; 
		    int intValue = -2147483648; 
		    uint uintValue = 4294967295; 
		    long longValue = -922337203685477508; 
		    ulong ulongValue = 18446744073709551615; 
		    char charValue = 'K';
		    Console.WriteLine("byteValue:" + byteValue);
		    Console.WriteLine("ubyteValue:" + ubyteValue);
		    Console.WriteLine("shortValue:" + shortValue);
		    Console.WriteLine("ushortValue:" + ushortValue);
		    Console.WriteLine("intValue:" + intValue);
		    Console.WriteLine("uintValue:" + uintValue);
	    	Console.WriteLine("longValue:" + longValue);
	    	Console.WriteLine("ulongValue:" + ulongValue);
		    Console.WriteLine("charValue:" + charValue);
		}
	}
}
