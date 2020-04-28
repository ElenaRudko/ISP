using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
namespace ConsoleApp15
{
	class Program
	{
		static void Main(string[] args)
		{
			Assembly dll = Assembly.Load("dllcsharp");
			Type tp = dll.GetType("dllcsharp.BasicInfo");
			object ob = Activator.CreateInstance(tp);
			MethodInfo mi;
			mi = tp.GetMethod("print");
			mi.Invoke(ob, null);
			Console.ReadKey();
		}
	}
}