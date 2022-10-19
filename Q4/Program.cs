using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q4假設有表示日期的字串"1100225", 請將它轉成表示西元年的日期"20210225"
			//寫法1
			/*string date = "1100225";
			string dt = date.Replace("110", "2021");
			Console.WriteLine(dt);*/

			//寫法2
			string date = "1100225";
			//字串擷取成年月日
			int year = Convert.ToInt32(date.Substring(0, 3)); 
			int month = Convert.ToInt32(date.Substring(3, 2));
			int day = Convert.ToInt32(date.Substring(5, 2));
			//轉西元年
			int yearCE = year + 1911; 
			DateTime dt = new DateTime(yearCE,month,day);
			Console.WriteLine($"{dt:yyyyMMdd}");


		}
	}
}
