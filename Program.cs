using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace laba3
{
	class People
	{
		private static int objectsCounter;
		private string Name { get; set; }
		protected string Sex { get; set; }
		protected string getName()
		{
			return Name;
		}
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
		public People(string name, string sex)
		{
			Name = name;
			Sex = sex;
			objectsCounter++;
		}
		public People()
		{
			Console.WriteLine("Введите ФИО:");
			Name = Console.ReadLine();
			Console.WriteLine("Введите ПОЛ:");
			Sex = Console.ReadLine();
			objectsCounter++;
		}
		public static void NumberOfObjects()
		{
			Console.WriteLine("Number of objects is " + objectsCounter);
		}
	}
	class Student : People
	{
		protected int Group { get; set; }
		public Student(string name, string sex, int group)
			: base(name, sex)
		{
			Group = group;
		}
		public Student()
		{
			Console.WriteLine("Введите группу:");
			Group = int.Parse(Console.ReadLine());
		}
	}
	class Speciality : Student
	{
		private string Specialty { get; set; }
		public Speciality(string name, string sex, int group, string specialty)
			: base(name, sex, group)
		{
			Specialty = specialty;
		}
		public Speciality()
		{
			Console.WriteLine("Введите специальность:");
			Specialty = Console.ReadLine();
		}
		public void OutputInformation()
		{
			Console.WriteLine("ФИО: " + getName());
			Console.WriteLine("Пол: " + Sex);
			Console.WriteLine("Группа: " + Group);
			Console.WriteLine("Cпециальность: " + Specialty);
			Console.WriteLine();
		}
		//Перегрузка.
		public void OutputInformation(params string[] args)
		{
			Console.WriteLine("FIO: " + getName());
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
			People.NumberOfObjects();
			Console.WriteLine("Введите количество студентов: ");
			int kol = int.Parse(Console.ReadLine());
			Speciality[] mas = new Speciality[kol];
			for (int i = 0; i < kol; i++)
			{
				Console.WriteLine("Введите информацию о {0} студенте ", i + 1);
				mas[i] = new Speciality();
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
