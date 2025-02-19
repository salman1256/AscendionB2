//using System;

//namespace ConAppAnonymousMethod
//{
//    public delegate void OurDel(string name);
//    public delegate double MathDel(double num1,double num2);
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            OurDel ourDel = delegate (string s) { Console.WriteLine(s); };
//            ourDel("Sameer");
//            MathDel del = delegate (double fnum, double snum) { return fnum + snum; };
//            double result=del(45.50, 56.30);
//            Console.WriteLine("Result : \t"+result);
//            Console.ReadKey();  
//        }
//    }
//}
//Lambda
using System;
using System.Runtime.InteropServices;

namespace ConAppAnonymousMethod
{
    public delegate void OurDel(string name);
    public delegate double MathDel(double num1, double num2);
    internal class Program
    {
        static void Main(string[] args)
        {
            OurDel ourDel = s=> { Console.WriteLine("Welcome:\t "+s); };
            ourDel("Sameer");
            MathDel mathDel = (f, s) => f * s;
            Console.WriteLine("Result after multiplication: \t"+mathDel(12.45,2));
            Console.WriteLine("-------------------------------------");
            ourDel += (msg) => Console.WriteLine("Herea is msg for you"+msg);
            
            ourDel("Sam");

            Console.ReadKey();
        }
    }
}
