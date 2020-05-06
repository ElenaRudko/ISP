using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
	enum Education
	{
		Full_Time,
		Distance,
		Evening,
		Magistracy
	}
	interface IInformation
	{
		void Uni();
		void Information();
	}
	class Person
	{
		public static int Counter
		{
			get
			{
				return objectsCounter;
			}
		}

		private static int objectsCounter;
		protected struct Student
		{
			string fio;
			public string FIO
			{
				get { return fio; }
				set
				{
					fio = value;
				}
			}
		}

		public string Education;
		protected Student student;
		public Person(string fio, int education)
		{
			student.FIO = fio;
			Education = Enum.GetName(typeof(Education), education);
			objectsCounter++;
		}
		public void Information()
		{
			Console.WriteLine("ФИО студента: " + student.FIO);
			Console.WriteLine("Вид обучения: " + Education);
			objectsCounter++;
		}
		public virtual void Uni() { }
		public static void Number()
		{
			Console.WriteLine("Количество студентов: " + objectsCounter);
		}
	}

	class Programmer : Person, IInformation
	{
		int Course;
		public Programmer(string fio, int education, int course) : base(fio, education)
		{
			Course = course;
		}
		public new void Information()
		{
			Console.WriteLine("ФИО студента: " + student.FIO);
			Console.WriteLine("Вид обучения: " + Education);
			Console.WriteLine("Курс: " + Course);
			Console.WriteLine("---------------------------------------------------- ");
		}
		public override void Uni()
		{
			Console.WriteLine("Университет: БГУИР");
		}
	}

	class Engineer : Person, IInformation, IComparable<Engineer>
	{
		string Faculty;
		public Engineer(string fio, int education, string faculty) : base(fio, education)
		{
			Faculty = faculty;
		}
		public new void Information()
		{
			Console.WriteLine("ФИО студента: " + student.FIO);
			Console.WriteLine("Вид обучения: " + Education);
			Console.WriteLine("Факультет: " + Faculty);
			Console.WriteLine("---------------------------------------------------- ");
		}
		public override void Uni()
		{
			Console.WriteLine("Университет: БГУИР");
		}
		public int CompareTo(Engineer other)
		{
			return this.Faculty.CompareTo(other.Faculty);

		}
	}

	class Tester : Person, IInformation, IEquatable<Tester>
	{
		int Age;
		public Tester(string fio, int education, int age) : base(fio, education)
		{
			Age = age;
		}
		public new void Information()
		{
			Console.WriteLine("ФИО студента: " + student.FIO);
			Console.WriteLine("Вид обучения: " + Education);
			Console.WriteLine("Возраст: " + Age);
			Console.WriteLine("---------------------------------------------------- ");
		}
		public override void Uni()
		{
			Console.WriteLine("Университет: БГУИР");
		}

		public bool Equals(Tester other)
		{
			return this.Age.Equals(other.Age);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Programmer programmer = new Programmer("Рудько Елена Сергеевна", 2, 4);
			Engineer engineer = new Engineer("Пульмановская Екатерина Дмитриевна", 1, "ФРЭ");
			Tester tester = new Tester("Петроченко Маргарита Сергеевна", 3, 20);
			programmer.Uni();
			programmer.Information();
			engineer.Uni();
			engineer.Information();
			tester.Uni();
			tester.Information();
			Person.Number();
			Console.WriteLine(tester.Equals(engineer));
			Console.WriteLine(engineer.CompareTo(engineer));

			Console.ReadLine();
		}
	}
}