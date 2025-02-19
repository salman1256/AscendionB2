using System;

namespace ConAppInterfaceExampleTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OurClass obj = new OurClass();
            //obj.Welcome("Sameer");
            //obj.Display();
            //Console.ReadKey();  
            IOne one=new OurClass();
            one.Display();
            ITwo two=new OurClass();
            two.Display();  
            Console.ReadKey();  
        }
    }
}
