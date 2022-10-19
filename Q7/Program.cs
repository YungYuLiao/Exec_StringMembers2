using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q7隱藏手機的資訊，呈現 0935****46
			Console.Write("請輸入行動電話號碼: ");
			string input = Console.ReadLine();
			string encryptedPhoneNumber = input.Substring(0,4)+new string('*',4)+input.Substring(8,2);
			Console.WriteLine(encryptedPhoneNumber);

		}
	}
}
