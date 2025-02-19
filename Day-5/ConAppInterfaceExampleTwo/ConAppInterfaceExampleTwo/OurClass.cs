//using System;
//namespace ConAppInterfaceExampleTwo
//{
//    public class OurClass : IOne, ITwo
//    {
//        public void Display()
//        {
//            Console.WriteLine("Display Method of Interface One");
//        }

//        public void Welcome(string name)
//        {
//            Console.WriteLine("Welcome to Interface Two Mr.\\Ms."+name);
//        }
//    }
//}
using System;
namespace ConAppInterfaceExampleTwo
{
    public class OurClass : IOne, ITwo
    {
        void IOne.Display()
        {
            Console.WriteLine("Im coming from Interface One");
        }

        void ITwo.Display()
        {
            Console.WriteLine("Display of intreface Two");
        }
    }
}