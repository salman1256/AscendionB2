using System;
namespace ConAppEventExample
{
    public class OrderEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string Mobile { get; set; }

    }
}
