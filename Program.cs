using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace laba3
{
	class People
	{
		public static int GetObjectsCounter
		{
			get
			{
				return objectsCounter;
			}

		}
		private static int objectsCounter;
		private int Group;
		private string Specialty;
		private string Name;
		public string Property
		{
			get
			{
				return Name;
			}

			set
			{
				Name = value;
			}
		}
		protected string Sex;
		public string this[string prop]
		{
			get
			{
				switch (prop)
				{
					case "name": return Name;
					case "pol": return Sex;
					default: return "не найдено";
				}
			}
			set
			{
				switch (prop)
				{
					case "name":
						Name = value;
						break;
					case "sex":
						Sex = value;
						break;
					default:
						break;
				}
			}
		}

		public People(string name, string sex,string spicialty,int group)
		{
			Name = name;
			Sex = sex;
			Specialty = spicialty;
			Group = group;
			objectsCounter++;
		}

		public People()
		{
			Console.WriteLine("Введите ФИО:");
			Name = Console.ReadLine();
			Console.WriteLine("Введите ПОЛ:");
			Sex = Console.ReadLine();
			Console.WriteLine("Введите специальность:");
			Specialty = Console.ReadLine();
			Console.WriteLine("Введите группу:");
			Group = int.Parse(Console.ReadLine());
			objectsCounter++;
		}
		public static void NumberOfObjects()
		{
			Console.WriteLine("Number of objects is " + objectsCounter);
		}
		public void OutputInformation()
		{
			Console.WriteLine("ФИО: " + Property);
			Console.WriteLine("Пол: " + Sex);
			Console.WriteLine("Группа: " + Group);
			Console.WriteLine("Cпециальность: " + Specialty);
			Console.WriteLine();
		}
		//Перегрузка.
		public void OutputInformation(params string[] args)
		{
			Console.WriteLine("FIO: " + Property);
			Console.WriteLine("Sex: " + Sex);
			Console.WriteLine("Group: " + Group);
			Console.WriteLine("Specialitys: " + Specialty);
			foreach (var x in args)
			{
				Console.WriteLine(x);
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(People.GetObjectsCounter);
			Console.WriteLine("Введите количество студентов: ");
			int kol = int.Parse(Console.ReadLine());
			People [] mas = new People[kol];

			for (int i = 0; i < kol; i++)
			{
				Console.WriteLine("Введите информацию о {0} студенте ", i + 1);
				mas[i] = new People();

				Console.WriteLine("*********************************");
			}
			for (int i = 0; i < kol; i++)
			{
				mas[i].OutputInformation("Проверка", "Перегрузка");
			}
			People.NumberOfObjects();
			Console.WriteLine(mas[0]["name"]);
			mas[0]["name"] = "Лена";
			Console.ReadLine();
		}
	}
}