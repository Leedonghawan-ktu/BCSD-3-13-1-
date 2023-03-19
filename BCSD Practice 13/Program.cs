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
			int? intValue;
			intValue = null;
			Console.WriteLine(intValue.HasValue);
			intValue = 30;
			Console.WriteLine( intValue.HasValue);
			Console.WriteLine( intValue.Value); 
			var valueInt = 33; 
			var valueFloat = 33.4567f; 
			var valueString = "문자열";
			Console.WriteLine("정수 : "+valueInt);
			Console.WriteLine("실수 "+valueFloat);
			Console.WriteLine("문자열 : "+valueString);
		}
	}
}