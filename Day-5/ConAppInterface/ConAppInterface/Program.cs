using System;

namespace ConAppInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurDrive ourDrive = new OurDrive();
            ourDrive.Display();
            Console.WriteLine("Our Interface Property: "+ourDrive.MyProperty);
            Console.ReadKey();
        }
    }
}
