using System;
using System.Collections.Generic;


namespace ConAppGenCollectionEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> emps = new List<Emp>()
            {
                new Emp() {Id=1,Fname="Sam",Lname="Dicosta",Salary=99000.90,DOJ=new DateTime(day:25,month:1,year:2024)},
                new Emp() {Id=2,Fname="Deep",Lname="Das",Salary=87000.50,DOJ=new DateTime(day:27,month:01,year:2023)},
                new Emp() {Id=3,Fname="Arsh",Lname="Maan",Salary=86000.90,DOJ=new DateTime(day:18,month:08,year:2022)},
                new Emp() {Id=5,Fname="Rooh",Lname="Nazeer",Salary=76000.30,DOJ=new DateTime(day:02,month:1,year:2025)},
               new Emp() {Id=4,Fname="Dhiraj",Lname="Vinayak",Salary=85000.50,DOJ=new DateTime(day:01,month:11,year:2023)}
            };
            Console.WriteLine("Number of Employees: \t"+emps.Count);
            Console.WriteLine("ID \t First Name \t Last Name \t Salary \t Date of Joining");
            foreach (Emp e in emps)
            {
                Console.Write(e.Id+"\t");
                Console.Write(e.Fname + "\t\t");
                Console.Write(e.Lname + "\t\t");
                Console.Write(e.Salary + "\t\t");
                Console.Write(e.DOJ.ToShortDateString());
                Console.WriteLine();
            }
            Emp obj=new Emp();
            Console.WriteLine("Enter Id");
            obj.Id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  First Name");
            obj.Fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            obj.Lname = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            obj.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining");
            obj.DOJ= DateTime.Parse(Console.ReadLine());
            emps.Add(obj);
            Console.WriteLine("Number of Employees: \t" + emps.Count);
            Console.WriteLine("ID \t First Name \t Last Name \t Salary \t Date of Joining");
            foreach (Emp e in emps)
            {
                Console.Write(e.Id + "\t");
                Console.Write(e.Fname + "\t\t");
                Console.Write(e.Lname + "\t\t");
                Console.Write(e.Salary + "\t\t");
                Console.Write(e.DOJ.ToShortDateString());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
