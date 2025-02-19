using System;

namespace ConAppClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            Console.WriteLine("Number of Employees: \t"+Emp.Noe);
            Emp emp2 = new Emp();
            Console.WriteLine("Number of Employees: \t" + Emp.Noe);
            Emp emp3 = new Emp();
            Console.WriteLine("Number of Employees: \t" + Emp.Noe);
            //Console.WriteLine("Initial Details");
            //Console.WriteLine($"ID:{emp.Id} Name:{emp.Name} Salary{emp.Salary}");

            //Console.WriteLine("Enter Id");
            //emp.Id=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();
            //Console.WriteLine("Enter Salary");
            //emp.Salary = double.Parse(Console.ReadLine());
            //Console.WriteLine("Employee Details");
            //Console.WriteLine($"ID:{emp.Id} Name:{emp.Name} Salary{emp.Salary}");
            Console.ReadKey();  


        }
    }
}
