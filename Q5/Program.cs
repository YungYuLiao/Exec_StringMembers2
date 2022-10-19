using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q5比對使用者輸入值是否為 "Allen" 不拘大小寫
			Console.Write("請輸入使用者名稱: ");
			string input = Console.ReadLine();
			string name = "Allen"; 
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒輸入");
				return;	
			}
			string result = (input.ToUpper() == name.ToUpper() ) ? "輸入正確" : "輸入錯誤";
			Console.WriteLine(result);
		}
	}
}
