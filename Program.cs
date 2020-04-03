using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace laba3
{
	class People
	{
		protected static int objectsCounter;
		protected string Name { get; set; }
		protected string Pol { get; set; }
		public string this[string st]
		{
			get
			{
				switch (st)
				{
					case "name": return Name;
					case "pol": return Pol;
					default: return "не найдено";
				}
			}
			set
			{
				switch (st)
				{
					case "name":
						Name = value;
						break;
					case "pol":
						Pol = value;
						break;
					default:
						break;
				}
			}
		}
		public People(string name, string pol)
		{
			Name = name;
			Pol = pol;
			objectsCounter++;
		}
		public People()
		{
			Console.WriteLine("Введите ФИО:");
			Name = Console.ReadLine();
			Console.WriteLine("Введите ПОЛ:");
			Pol = Console.ReadLine();
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
		public Student(string name, string pol, int group)
			: base(name, pol)
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
		protected string Specialty { get; set; }
		public Speciality(string name, string pol, int group, string specialty)
			: base(name, pol, group)
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
			Console.WriteLine("ФИО: " + Name);
			Console.WriteLine("Пол: " + Pol);
			Console.WriteLine("Группа: " + Group);
			Console.WriteLine("Cпециальность: " + Specialty);
			Console.WriteLine();
		}
		//Перегрузка.
		public void OutputInformation(params string[] args)
		{
			Console.WriteLine("FIO: " + Name);
			Console.WriteLine("pol: " + Pol);
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
				mas[i].OutputInformation("Прошла перегрузка\n");
			}
			People.NumberOfObjects();
			Console.WriteLine(mas[0]["name"]);
			mas[0]["name"] = "Лена";
			Console.ReadLine();
		}
	}
}
