using System;

namespace ConAppInheritance
{
   public class Emp
    {
        int id;
        string name;
        string qual;
        public Emp()
        {
            Console.WriteLine("Emp Constructor");
            id = -1;
            name = "not given";
            qual = "not given";
        }
        public virtual void Register()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Qualification");
            qual = Console.ReadLine();
        }
        public  virtual void Display()
        {
            Console.WriteLine("ID: \t"+id);
            Console.WriteLine("Name: \t" + name);
            Console.WriteLine("Qualification: \t" + qual);
        }
    }
}
