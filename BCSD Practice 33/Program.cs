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
			int i, j;
			string starpicture = "";
			for (i = 0; i < 5; ++i)
			{
				starpicture = "";
				for (j = 0; j <= i; ++j)
				{
					starpicture += "★";
				}
				for (j=i+1; j < 5; ++j)
				{
					starpicture += "☆";
				}

				Console.WriteLine(starpicture);
			}
		}
	}
}