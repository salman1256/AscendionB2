using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;


namespace ConAppLinqExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 11, 12, 13, 13, 14 };
            //var evenNumbers=from mynums in numbers where mynums%2==0 select mynums;
            //Console.WriteLine("All Even Numbers ");
            //foreach (int i in evenNumbers)
            //{
            //    Console.WriteLine(i);
            //}
            //var oddNumbers = from mynums in numbers where mynums % 2 == 1 select mynums;
            //Console.WriteLine("Odd Numbers ");
            //foreach (int i in oddNumbers)
            //{
            //    Console.WriteLine(i);
            //}

            //var evens=numbers.Where(n=>n%2==0);
            //Console.WriteLine("Second Way Even Numbers ");
            //foreach (int i in evens)
            //{
            //    Console.WriteLine(i);
            //}

            //var odds= numbers.Where(n => n % 2 == 1);
            //Console.WriteLine("Second Way Odd Numbers ");
            //foreach (int i in odds)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Total Numbers in Array \t"+numbers.Count());
            //Console.WriteLine("Average of Numbers in Array \t" + numbers.Average());
            //Console.WriteLine("Sum of Numbers in Array \t" + numbers.Sum());
            //Console.WriteLine("Max of Numbers in Array \t" + numbers.Max());
            //Console.WriteLine("Min of Numbers in Array \t" + numbers.Min());
            //Console.ReadKey();
            //string[] names = {"aman","sam","ravi","amit","vijay","jai","gagan","deep","anil","Niraj"};
            //var query = names.Where(n => n.Contains("n"));
            //foreach (var name in query)
            //{
            //    Console.WriteLine(name);
            //}

            //var query2 = names.Where(n => n.Contains("n")&& n.Length >=5);
            //Console.WriteLine("Contains n and length greater than equal to 5");
            //foreach (var name in query2)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadKey();
            List<Emp> emps = new List<Emp>()
            {
                new Emp(){Id=1,Name="Sam",Salary=98000.30,Designation="Manager",DOJ= new DateTime(day:12,month:01,year:2024)},
                new Emp(){Id=2,Name="Raj",Salary=34000.90,Designation="HR",DOJ= new DateTime(day:12,month:08,year:2021)},
                new Emp(){Id=3,Name="Ravi",Salary=58000.90,Designation="Developer",DOJ= new DateTime(day:12,month:09,year:2022)},
                new Emp(){Id=4,Name="Mithun",Salary=76000.90,Designation="Tester",DOJ= new DateTime(day:02,month:12,year:2023)},
                new Emp(){Id=5,Name="Sam",Salary=81000.50,Designation="Tester",DOJ= new DateTime(day:09,month:12,year:2024)},
                new Emp(){Id=6,Name="Ravi",Salary=54000.90,Designation="HR",DOJ= new DateTime(day:24,month:12,year:2023)},
                new Emp(){Id=9,Name="Gagan",Salary=76000.70,Designation="Manager",DOJ= new DateTime(day:23,month:01,year:2020)},
            };
            //var query = emps.Where(e => e.Id >= 5);
            //foreach (Emp emp in query)
            //{
            //    Console.WriteLine(emp.Id+"-> "+emp.Name+"-> "+emp.Salary+" ->"
            //        +emp.Designation+"-> "+emp.DOJ.ToShortDateString());
            //}
            //Console.WriteLine("Enter Designation to find out details");
            //string desg = Console.ReadLine();
            //var query2 = emps.Where(e => e.Designation==desg);

            //Console.WriteLine($"************List of {desg} ***************");
            //foreach (Emp emp in query2)
            //{
            //    Console.WriteLine(emp.Id + "-> " + emp.Name + "-> " + emp.Salary + " ->"
            //        + emp.Designation + "-> " + emp.DOJ.ToShortDateString());
            //}
            //try
            //{
            //    int id;
            //    Console.WriteLine("Enter Id to find out Employee Details");
            //    id = int.Parse(Console.ReadLine());
            //    Emp emp = emps.SingleOrDefault(e => e.Id == id);
            //    if (emp != null)
            //    {
            //        Console.WriteLine("Record Found Details as follows!!!");
            //        Console.WriteLine(emp.Id + "-> " + emp.Name + "-> " + emp.Salary + " ->"
            //           + emp.Designation + "-> " + emp.DOJ.ToShortDateString());
            //    }
            //    else { Console.WriteLine($"No such Employee Id {id} exist"); }
            //}
            //catch (Exception ex){ Console.WriteLine("Error!!!"+ex.Message); }
            //finally { Console.WriteLine("End of Program"); Console.ReadKey(); }

            //try
            //{
            //    string name;
            //    Console.WriteLine("Enter Name to find out Employee Details");
            //    name = Console.ReadLine();
            //    Emp emp = emps.FirstOrDefault(e => e.Name == name);
            //    if (emp != null)
            //    {
            //        Console.WriteLine($"Record Found for {name} Details as follows!!!");
            //        Console.WriteLine(" ID: \t"+emp.Id + "\n Name: \t " + emp.Name 
            //            + "\n Salary:\t " + emp.Salary + "\n Designation: \t"
            //           + emp.Designation + "\n Date of Joinig: \t " + emp.DOJ.ToShortDateString());
            //    }
            //    else { Console.WriteLine($"No such Employee  {name} exist"); }
            //}
            //catch (Exception ex) { Console.WriteLine("Error!!!" + ex.Message); }
            //finally { Console.WriteLine("End of Program"); Console.ReadKey(); }
            string name;
            Console.WriteLine("Enter Name to find out Employee Details");
            name = Console.ReadLine();
            var result1 = emps.Where(e=>e.Name == name).ToList();
            if (result1.Count >= 1)
            {  foreach (Emp emp in result1)
                { Console.WriteLine(" ID: \t" + emp.Id + "\n Name: \t " + emp.Name
                      + "\n Salary:\t " + emp.Salary + "\n Designation: \t"
                      + emp.Designation + "\n Date of Joinig: \t " + emp.DOJ.ToShortDateString());
                }
            }
            else
            {
                Console.WriteLine($"No Such Name {name} exist");
            }
            var result = emps.OrderBy(emp => emp.Name).ToList();
            Console.WriteLine("In order of Name");
            foreach (Emp emp in result)
            {  Console.WriteLine(" ID: \t" + emp.Id + "\n Name: \t " + emp.Name
                       + "\n Salary:\t " + emp.Salary + "\n Designation: \t"
                       + emp.Designation + "\n Date of Joinig: \t " + emp.DOJ.ToShortDateString());
            }
            var result2 = emps.OrderByDescending(emp => emp.Name).ToList();
            Console.WriteLine("In Descending order of Name");
            foreach (Emp emp in result2)
            {
                Console.WriteLine(" ID: \t" + emp.Id + "\n Name: \t " + emp.Name
                       + "\n Salary:\t " + emp.Salary + "\n Designation: \t"
                       + emp.Designation + "\n Date of Joinig: \t " + emp.DOJ.ToShortDateString());
            }
            Console.ReadKey();
            
        }
    }
}
