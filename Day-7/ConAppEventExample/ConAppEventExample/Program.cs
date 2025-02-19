//using System;
//namespace ConAppEventExample
//{
//    public delegate void PrintDetails();
//    class Program
//    {  //event DelegateName EventName
//        event PrintDetails Print;
//        void Show()
//        {
//            Console.WriteLine("This program illustrate how to subscribe objects   to an event");
//            Console.WriteLine("This method will not execute since the event has  not been raised");
//        }
//        static void Main(string[] args)
//        {
//            Program objTestEvent = new Program();
//            objTestEvent.Print += new PrintDetails(objTestEvent.Show);

//            Console.WriteLine("Do You wanna print if yes press p");
//            string print = Console.ReadLine().ToLower();
//            if (print == "p")
//            {
//                objTestEvent.Print.Invoke();
//            }

//            Console.ReadKey();
//        }
//    }
//}
using System;
namespace ConAppEventExample
{
   
    class Program
    {  
        static void Main(string[] args)
        {
            Order order = new Order();
            order.OnCreated += Email.Send;
            order.OnCreated += SMS.Send;
            Console.WriteLine("Enter Your Mobile Number");
            string mobile=Console.ReadLine();
            Console.WriteLine("Enter Your Email Address");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Food Items You wanna Order");
            string orderItems=Console.ReadLine();
           order.OrderPlace(email,mobile,orderItems);
              Console.ReadKey();
        }
    }
}