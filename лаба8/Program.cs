using System;

namespace LR8
{
    delegate void WelcomeMessage(string lastName, string name);
    delegate void EndOfWork(string name);
	
    interface IInformation
    {
	void Uni();
	void Info();
    }

    struct Information
    {
	string name;
	string specialty;
	int age;
	
        public string Name
        {
	   get { return name; }
	   set
	   {
	       if (!String.IsNullOrEmpty(value) && value.Length > 1)
	       {
	          name = value;
	       }
	       else
	          Console.WriteLine("incorrect value.");
	   }
        }

        public string Specialty
        {
	   get { return specialty; }
	   set
	   {
	       if (!String.IsNullOrEmpty(value) && value.Length > 1)
	       {
	          specialty = value;
	       }
	       else
	          Console.WriteLine("incorrect value.");
	   }
        }
	    
        public int Age
        {
	   get { return age; }
	   set
	   {
	       if (value >= 21 & value < 35)
	          age = value;
	       else
	          Console.WriteLine("incorrect value.");
	   }
        }
    }

    class Person
    {
        public event EventHandler EndOfCareer;
        protected Information participant;
        protected string Education { get; set; }
	    
        public Person(string specialty, string name, int age, string education)
        {
           participant.Specialty = specialty;
	   participant.Name = name;
	   participant.Age = age;
	   Education = education;
        }
	    
        public void DisplayInfo()
        {
	   Console.WriteLine("Specialty: " + participant.Specialty);
	   Console.WriteLine("Name: " + participant.Name);
	   Console.WriteLine("Age: " + participant.Age);
	   Console.WriteLine("Education: " + Education);
        }
	    
        public string ReturnSpecialty() => participant.Specialty;
	    
        public string ReturnName() => participant.Name;
	    
        public void Training()
        {
	   int ageStudent = this.participant.Age;
	   for (int i = ageStudent; i <= 35; i++)
	   {
	       if (ageStudent >= 35)
	       {
		  EndOfCareer?.Invoke(this, new EventArgs());
	       }
	       ++ageStudent;
	   }
	}
	    
	delegate void MessageHandler(string message);
	    
	public void Show()
	{
	    try
	    {
	       throw new ArgumentException("The generation of an error.");
	    }
	    catch (Exception ex)
	    {
	       Console.WriteLine(ex.Message);
	    }
	    ShowMessage("hello!", (string mes) => Console.WriteLine(mes));
	}
	    
	static void ShowMessage(string mes, MessageHandler handler)
	{
	    handler(mes + " MassageHabdler");
	}
    }

    class Programmer : Person, IInformation
    {
	string Faculty;
	
	public Programmer(string specialty, string name, int age, string country, string faculty) :
	     base(specialty, name, age, country)
	{
	     Faculty = faculty;
	}
	
	public void Uni()
	{
	     Console.WriteLine("Univer: BSUIR");
	}
	
	public void Info()
	{
	     Console.WriteLine("Faculty: " + Faculty);
	}
    }

    class Engineer : Person, IInformation, IComparable<Engineer>
    {
	int Course { get; set; }
	
	public Engineer(string specialty, string name, int age, string country, int course) :
	     base(specialty, name, age, country)
	{
	     Course = course;
	}
	
	public void Uni()
	{
	     Console.WriteLine("\nUniver: BSUIR");
	}
	
	public void Info()
	{
		Console.WriteLine("Course: " + Course);
	}
	public int CompareTo(Engineer obj)
	{
	        if (this.Course > obj.Course)
		   return 1;
		else if (this.Course < obj.Course)
		   return -1;
		else
		   return 0;
	}
    }

    class Tester : Person, IInformation
    {
	string Kafedra { get; set; }
	
	public Tester(string specialty, string name, int age, string country, string kafedra) :
	     base(specialty, name, age, country)
	{
	     Kafedra = kafedra;
	}
	
	public void Uni()
	{
	     Console.WriteLine("\nUniver: BSUIR");
	}
	
	public void Info()
	{
	     Console.WriteLine("Kafedra: " + Kafedra);
	}
    }

    class Program
    {
	static void Main(string[] args)
	{
	     Programmer prog = new Programmer("Elena", "Programmer", 20, "Distance", "FRE");
	     Engineer engineer = new Engineer("Ivan", "Programmer", 21, "Evening", 1);
	     Tester tester = new Tester("Vlad", "Programmer", 20, "Magistracy", "kafedra");
		
	     prog.Uni();
	     prog.DisplayInfo();
	     prog.Info();
		
	    engineer.Uni();
	    engineer.DisplayInfo();
	    engineer.Info();
		
	    tester.Uni();
	    tester.DisplayInfo();
	    tester.Info();
		
	    Console.WriteLine("\nSorting\n");
		
	    Engineer[] mas = new Engineer[3];
		
	    mas[0] = new Engineer("Elena", "Programmer", 20, "Belarus", 1);
	    mas[1] = new Engineer("Ivan", "Ingenior", 21, "Belarus", 3);
	    mas[2] = new Engineer("Vlad", "Programmer", 20, "Belarus", 2);
		
	    Array.Sort(mas);
		
	    foreach (Engineer x in mas)
	    {
		   x.DisplayInfo();
		   Console.WriteLine();
	    }
		
	    WelcomeMessage message = Greeting;
	    message += DisplayWinner;
	    message(engineer.ReturnSpecialty(), engineer.ReturnName());
		
	    message -= DisplayWinner;
	    message(engineer.ReturnSpecialty(), engineer.ReturnName());
		
	    message -= Greeting;
	    message?.Invoke(engineer.ReturnSpecialty(), engineer.ReturnName());
		
	    EndOfWork handler = delegate (string name)
	    {
		   Console.WriteLine($"\nBye, {name}");
	    };
		
	    handler(tester.ReturnName());
		
            tester.EndOfCareer += (object sender, EventArgs eventArgs) => Console.WriteLine($"\nYou've finished your studies, {tester.ReturnSpecialty()} {tester.ReturnName()}");
	    tester.Training();
		
	    tester.Show();
	    Console.ReadLine();
	}
	    
	static void Greeting(string specialty, string name)
	{
	    Console.WriteLine($"Welcome, {specialty} {name}");
	}
	    
	static void DisplayWinner(string specialty, string name)
	{
	    Console.WriteLine($"You're an excellent student, {specialty} {name}");
	}
    }
}
