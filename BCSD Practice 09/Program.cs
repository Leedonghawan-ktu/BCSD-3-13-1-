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
			string stringValue = "숫자가 아닙니다."; 
			int intValue = 10; 
			bool isConversion = int.TryParse(stringValue, out intValue);
			if (isConversion == true)
			{
				Console.WriteLine("stringValue " + stringValue);
				Console.WriteLine("intValue : " + intValue);
			}
			else
			{
				Console.WriteLine("stringValue 변수에 들어있는 내용이 숫자가 아니어서 형변환에 실패하였습니다.");
			}
		}
	}
}