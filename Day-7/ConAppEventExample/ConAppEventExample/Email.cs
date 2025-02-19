using System;

namespace ConAppEventExample
{
    public class Email
    {
        public static void Send(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"We have sent the email to {e.Email}");
        }
    }
}
