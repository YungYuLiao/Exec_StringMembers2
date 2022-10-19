using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q3 將字串 "aLLeN kUO" 轉換成 "Allen Kuo"
			//寫法1
			string name = "aLLeN kUO";
			/*
			string convert = name.ToLower(); //全改成小寫
			char[] nameAsChars = convert.ToCharArray(); //字串轉字元陣列 {a,l,l,e,n, ,k,u,o}
			nameAsChars[0] = 'A';
			nameAsChars[6] = 'K';

			for (int i = 0; i < nameAsChars.Length; i++)
			{
				Console.Write(nameAsChars[i]);
			}
			Console.WriteLine();*/

			//寫法2
			//將字串依空白分割成字串陣列
			string convert = name.ToLower(); //全改成小寫
			string[] nameSplit =convert.Split(' '); // [allen, kuo]
			for (int i = 0; i < nameSplit.Length; i++)
			{
				nameSplit[i] = nameSplit[i].Substring(0, 1).ToUpper() //選第一個字母變大寫後，丟回變數裡 A,K
					         + nameSplit[i].Substring(1); //把後面接回去 llen, uo

				Console.Write($"{nameSplit[i]} ");
			}
			Console.WriteLine();
			
			
			
		}
	}
}
