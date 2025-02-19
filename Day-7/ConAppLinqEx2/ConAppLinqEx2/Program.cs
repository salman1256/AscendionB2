using System;

namespace ConAppLinqEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Choose operation 1. Display 2. Add 3.SearchById 4.SearchByName 5.Update 6.Delete");
                IEmpHandler handler = new EmpHandler();
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {    Console.WriteLine("Id \t Name \t Salary \t Designation \t Date of Joining");
                            foreach (Emp e in handler.GetAllEmps())
                            {   Console.Write(e.Id + "\t");
                                Console.Write(e.Name + "\t");
                                Console.Write(e.Salary + "\t");
                                Console.Write(e.Designation + "\t");
                                Console.Write(e.DOJ + "\t");
                                Console.WriteLine("\n");
                            }

                            break;
                        }
                    case 2:
                        {     Emp emp = new Emp();
                            Console.WriteLine("Enter Employee Id");
                            emp.Id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Employee Name");
                            emp.Name = Console.ReadLine();
                            Console.WriteLine("Enter Employee Designation");
                            emp.Designation = Console.ReadLine();
                            Console.WriteLine("Enter Employee Salary");
                            emp.Salary = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Employee Date of Joinig");
                            emp.DOJ = DateTime.Parse(Console.ReadLine());
                            handler.CreateEmp(emp);
                                break;
                        }

                      
                }
                Console.WriteLine("Do you wanna continue... if yes press y");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
