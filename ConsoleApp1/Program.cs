using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//等腰星形三角形
			for(int i = 1; i <= 5; i++)
			{
				string row1 = new string(' ', 5 - i);
				string row2 = new string('*', i * 2 - 1);

				Console.WriteLine(row1 + row2);
			}
		}
	}
}
