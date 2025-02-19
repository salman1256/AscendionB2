using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp=new Emp();
            Dev dev = new Dev();
            AppDev appDev = new AppDev();
            Console.WriteLine("Enter Employee Details");
            emp.Register();
            Console.WriteLine("Enter Developer Details");
            dev.Register();
            Console.WriteLine("Enter App Developer Details");
            appDev.Register();
            //
            Console.WriteLine("Employee Details");
            emp.Display();
            //
            Console.WriteLine("Developer Details");
            dev.Display();
            //
            Console.WriteLine("App Developer Details");
            appDev.Display();

            Console.ReadKey();
        }
    }
}
