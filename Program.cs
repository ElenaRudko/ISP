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
		protected stringName { get; set; }
		protected string Pol { get; set; }
		public People(string name,string pol)
		{
			Name = name;
			Pol = pol;
			objectsCounter++;
		}
		public static void numberOfObjects()
		{
			Console.WriteLine("Number of objects is " + objectsCounter);
		}
		public void vvod()
		{
			Console.WriteLine("Введите ФИО");
			Name = Console.ReadLine();
			Console.WriteLine("Введите пол");
			Pol = Console.ReadLine();
			}
		public void vivod()
		{
			Console.WriteLine("ФИО: " + Name);
			Console.WriteLine("Пол: " + Pol);
		}
	}
	class Student : People
	{
		protected int Group { get; set; }
		public Student(string name,string pol,int group)
			: base(name,pol)
		{
			Group = group;
		}
		public  void vvod(int group)
		{
			Console.WriteLine("Введите группу студента: ");
			group = int.Parse(Console.ReadLine());
		}
		public  void vivod(int group)
		{
			Console.WriteLine("Группа студента" + group);
		}
		public void vivod(bool formatted)
		{
			Console.WriteLine("Group: " + Group);
			Console.WriteLine();
		}
	}
	class Speciality : Student
	{
		protected string Specialty { get; set; }
		public Speciality(string name,string pol, int group, string specialty)
			: base(name,pol, group)
		{
			Specialty = specialty;
		}
		public  void changeSpeciality()
		{
			Console.WriteLine("Введите специальность студента: ");
			Specialty = Console.ReadLine();
		}
		public void vvod()
		{
			Console.WriteLine("Введите имя студента: ");
			Name = Console.ReadLine();
			Console.WriteLine("Введите группу студента: ");
			Group = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите пол студента: ");
			Pol = Console.ReadLine();
			Console.WriteLine("Введите специальность студента: ");
			Specialty = Console.ReadLine();
			Console.WriteLine();
		}
		public void vivod()
		{
			Console.WriteLine("ФИО: " + Name);
			Console.WriteLine("Пол: " + Pol);
			Console.WriteLine("Группа: " + Group);
			Console.WriteLine("Cпециальность: " + Specialty);
			Console.WriteLine();
		}
		public void vivod(bool formatted)
		{
			Console.WriteLine("FIO: " + Name);
			Console.WriteLine("Pol: " + Pol);
			Console.WriteLine("Group: " + Group);
			Console.WriteLine("Specialitys: " + Specialty);
			Console.WriteLine();
		}
	}
	class Program
	{
		static void Main(string[] args)
	{
		Console.WriteLine("Введите количество студентов: ");
		int kol = int.Parse(Console.ReadLine());
		Speciality[] mas = new Speciality[kol];
		for (int i = 0; i < kol; i++)
		{
			mas[i] = new Speciality("Bob","m",3,"Prog");
			Console.WriteLine("*********************************");
			Console.WriteLine("Введите информацию о {0} студенте ", i + 1);
			mas[i].vvod();	
			}
		for (int i = 0; i < kol; i++)
		{
			mas[i].vivod();
			mas[i].vivod(true);
			}
			People.numberOfObjects();
			Console.ReadLine();
		}
    }
 }
 
