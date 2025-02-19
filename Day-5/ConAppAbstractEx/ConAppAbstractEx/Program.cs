using System;

namespace ConAppAbstractEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
           OurDriveClass obj = new OurDriveClass();
            obj.Welcome("Sam");
            obj.Display();
            Console.WriteLine(obj.OurAbProp);
            Console.WriteLine(obj.AbProp);
            Console.ReadKey();
        }
    }
}
