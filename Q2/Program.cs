using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q2將字串 "Allen Kuo" 轉成大寫 "ALLEN KUO"
			string name = "Allen Kuo";
			string upper = name.ToUpper();

			Console.WriteLine(upper);
		}
	}
}
