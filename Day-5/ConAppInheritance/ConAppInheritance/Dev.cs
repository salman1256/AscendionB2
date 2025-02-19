using System;

namespace ConAppInheritance
{
    public class Dev:Emp
    {
        string project;
        string domain;
        public Dev()
        {
            Console.WriteLine("Developer Constructor");
            project = "not assinged";
            domain = "not given";
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Project(s): \t"+project);
            Console.WriteLine("Domain: \t" + domain);
        }
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter Domain");
            domain = Console.ReadLine();
            Console.WriteLine("Enter Project");
            project=Console.ReadLine(); 
        }
    }
}
