using System;
namespace ConAppEventExample
{
    public class SMS
    {
        public static void Send(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"We have sent an sms to {e.Mobile}");
        }
    }
}
