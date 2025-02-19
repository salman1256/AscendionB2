using System;
using System.Collections.Generic;
using System.Linq;
namespace ConAppLinqEx2
{
    public class EmpHandler : IEmpHandler
    {
        private static List<Emp> emps = new List<Emp>()
            {
                new Emp(){Id=1,Name="Sam",Salary=98000.30,Designation="Manager",DOJ= new DateTime(day:12,month:01,year:2024)},
                new Emp(){Id=2,Name="Raj",Salary=34000.90,Designation="HR",DOJ= new DateTime(day:12,month:08,year:2021)},
                new Emp(){Id=3,Name="Ravi",Salary=58000.90,Designation="Developer",DOJ= new DateTime(day:12,month:09,year:2022)},
                new Emp(){Id=4,Name="Mithun",Salary=76000.90,Designation="Tester",DOJ= new DateTime(day:02,month:12,year:2023)},
                new Emp(){Id=5,Name="Sam",Salary=81000.50,Designation="Tester",DOJ= new DateTime(day:09,month:12,year:2024)},
                new Emp(){Id=6,Name="Ravi",Salary=54000.90,Designation="HR",DOJ= new DateTime(day:24,month:12,year:2023)},
                new Emp(){Id=9,Name="Gagan",Salary=76000.70,Designation="Manager",DOJ= new DateTime(day:23,month:01,year:2020)},
            };
        public void CreateEmp(Emp emp)
        {   emps.Add(emp);
            Console.WriteLine("Created!!!");
        }
        public void DeleteEmp(int id)
        {   Emp emp=emps.SingleOrDefault(e=>e.Id==id);
            if(emp!=null)
            {     emps.Remove(emp);       }
            else
            { Console.WriteLine($"No such Employee Id {emp.Id} exist"); }
        }
        public IEnumerable<Emp> GetAllEmps()    {    return emps;   }
        public Emp GetEmpById(int id)
        {  Emp emp = emps.SingleOrDefault(e => e.Id == id);          return emp;
        }
        public Emp GetEmpByName(string name)
        {   Emp emp = emps.FirstOrDefault(e => e.Name == name);            return emp;
        }
        public void UpdateEmp(Emp emp)
        {  var extEmp = GetEmpById(emp.Id);
            if (extEmp != null)
            {   extEmp.Name = emp.Name;
                extEmp.Salary = emp.Salary;
                extEmp.Designation = emp.Designation;
                extEmp.DOJ = emp.DOJ;
                 }
            else { Console.WriteLine($"No such Employee Id {emp.Id} exist"); }        }    } }