using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
namespace laba4d
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly dll = Assembly.Load("laba4");
            Type tp = dll.GetType("ClassLibrary1.BasicInfo");
            object ob = Activator.CreateInstance(tp);
            MethodInfo mi;
            mi = tp.GetMethod("print");
            mi.Invoke(ob,null);
           Console.ReadKey();
        }
    }
}
