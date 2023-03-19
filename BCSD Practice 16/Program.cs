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
			string str = "Hello, World";
			int numeric = str.IndexOf('o');
			Console.WriteLine(str); numeric = str.LastIndexOf('o');
			Console.WriteLine($"o는 뒤에서부터 {numeric}번쩨에 있습니다.");

			Console.WriteLine($"o는 앞에서부터 {numeric + 1}빈째에 있습니다.");
			bool isTrue = str.StartsWith("Hello");
			Console.WriteLine($"{str} 문장은 Hello부티 시작한다? {isTrue}");
			isTrue = str.StartsWith("World");
			Console.WriteLine($"{str} 문장은 World부터 시작한다? {isTrue}");
			isTrue = str.EndsWith("Hello");
			Console.WriteLine($" {str} 문장은 Hello로 끝난다? {isTrue}");
			isTrue = str.EndsWith("World");
			Console.WriteLine($"{str} 문장은 World로 끝난다? {isTrue}");
			isTrue = str.Contains("Hell");
			Console.WriteLine($"{str} 문장에 Hell이 포함되어 있다? {isTrue}");
		}
	}
}
