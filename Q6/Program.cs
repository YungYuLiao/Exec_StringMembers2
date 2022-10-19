using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q6比對使用者輸入值是否為 "Allen", 區分大小寫
			Console.Write("請輸入使用者名稱: ");
			string input = Console.ReadLine();
			string name = "Allen";
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒輸入");
				return;
			}
			string result = (input == name) ? "輸入正確" : "輸入錯誤";
			Console.WriteLine(result);
			
		}
	}
}
