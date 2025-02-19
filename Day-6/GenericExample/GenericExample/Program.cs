//using System;
//namespace GenericExample
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            OurGen<int> obji = new OurGen<int>(12);
//            OurGen<string> objs = new OurGen<string>("sam");
//            OurGen<float> objf = new OurGen<float>(12.45F);
//            obji.Display();
//            objs.Display();
//            objf.Display();
//            Console.ReadKey();  

//        }
//    }
//}

using System;
namespace GenericExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurGen<string,int> objsi = new OurGen<string,int>("Sam",34);
            OurGen<object, float> objof = new OurGen<object, float>("Deep", 13.5F);
            OurGen<string, char> objsc = new OurGen<string, char>("Deep", 'A');
            objsi.Display();
            objsc.Display(); 
            objof.Display();


            Console.ReadKey();

        }
    }
}
