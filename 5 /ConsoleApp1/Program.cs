using System;
namespace ConsoleApp1
{
	enum Education
	{
		Full_Time,
		Distance,
		Evening,
		Magistracy
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
		public Person(string fio,  int education)
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
	
class Programmer : Person
	{
		int Course;
		public Programmer( string fio,  int education, int course) : base( fio, education)
		{
			Course = course;
		}
		public new void Information()
		{
			Console.WriteLine("ФИО студента: " + student.FIO);
			Console.WriteLine("Вид обучения: " + Education);
			Console.WriteLine("Курс: " + Course);
			Console.WriteLine("---------------------------------------------------- " );
		}
		public override void Uni()
		{
			Console.WriteLine("Университет: БГУИР");
		}
	}
	
class Engineer : Person
	{
		string Faculty;
		public Engineer(string fio,  int education, string faculty) : base( fio, education)
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
	}
	
class Tester : Person
	{
		int Age;
		public Tester( string fio,  int education, int age) : base( fio, education)
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
		public override string Tester
        	{
            		get { return Age; }
            		set { Age = value; }
        }

		public override void Uni()
		{
			Console.WriteLine("Университет: БГУИР");
		}
	}
	
class Program
	{
		static void Main(string[] args)
		{
			Programmer programmer = new Programmer( "Рудько Елена Сергеевна", 2,4);
			Engineer engineer = new Engineer( "Пульмановская Екатерина Дмитриевна",  1, "ФРЭ");
			Tester tester = new Tester( "Петроченко Маргарита Сергеевна",  3, 20);
			programmer.Uni();
			programmer.Information();
			engineer.Uni();
			engineer.Information();
			tester.Uni();
			tester.Information();
			Person.Number();
			Console.ReadLine();
		}
        }
}
