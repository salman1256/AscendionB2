using System;

namespace ConAppDelegate
{
    public delegate string OurDel(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            OurDel del=new OurDel (OurClass.Welcome);
            Console.WriteLine(del("Suresh"));
            OurClass ourClass = new OurClass ();
            OurDel del2 = new OurDel(ourClass.Display);
            Console.WriteLine(del2("Lets Discuss Delegates"));
            
            Console.ReadKey();
        }
    }
}
