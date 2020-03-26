using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string str;
			Console.WriteLine("--------------Обратный порядок слов в строке---------------------");
			Console.WriteLine("\nВведите строку:");
			string d = Console.ReadLine();
			string[] words = d.Split(' ');//расщепляет на слова
			Console.WriteLine("Обратный поряд слов:");
			Array.Reverse(words);

			for (int i = 0; i < words.Length; i++)


			{


				Console.Write(words[i] + " ");


			}
			Console.WriteLine("\n--------------Текущие дата и время---------------------");
			DateTime date = DateTime.Now;

			string firstDate = date.ToString("F");
			string secondDate = date.ToString("G");
			


			Console.WriteLine("\nПервый формат: " + firstDate);
			ShowResult(firstDate);

			Console.WriteLine("\nВторой формат: " + secondDate);
			ShowResult(secondDate);
		
			Console.WriteLine("\n--------------Строка с знаками препинания---------------------");

			char[]s = new char[] { ',', '.', '-', ':', ';', '!', '?' };

			Console.Write("Введите строку: ");
			str = Console.ReadLine();
			StringBuilder strBuild = new StringBuilder(str);

			for (int i = 0; i < strBuild.Length; i++)
			{
				bool flag = false;
				for (int j = 0; j < s.Length; j++)
				{
					if (strBuild[i] == punctuationMarks[j])
					{
						for (int k = i; k >= 0; k--)
						{
							if (strBuild[k] == ' ')
							{

								strBuild.Insert(k + 1, s[j]);
								++i;
								flag = true;
								break;
							}
							else if (k == 0)
							{
								strBuild.Insert(k, s[j]);
								++i;
								flag = true;
								break;
							}
						}

					}
					if (flag)
						break;
				}
			}

			str = strBuild.ToString();

			Console.Write("Результат: ");
			foreach (char c in str)
				Console.Write(c);
			Console.ReadLine();
			Console.ReadKey();

		}

		static void ShowResult(string _date)
		{
			int[] result = new int[10];
			for (int i = 0; i < _date.Length; i++)
			{
				switch (_date[i])
				{
					case '1': result[1]++; break;
					case '2': result[2]++; break;
					case '3': result[3]++; break;
					case '4': result[4]++; break;
					case '5': result[5]++; break;
					case '6': result[6]++; break;
					case '7': result[7]++; break;
					case '8': result[8]++; break;
					case '9': result[9]++; break;
					case '0': result[0]++; break;
				}
				
			}

			Console.WriteLine("\nКоличество ");

			for (int i = 0; i < result.Length; i++)
				Console.WriteLine(i + " содержиться " + result[i]+" раз");
			
		}
		
	}
	
}
