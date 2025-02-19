using System;
namespace ConAppEventExample
{
  public class Order
    {
        public event EventHandler<OrderEventArgs> OnCreated;
        public void OrderPlace(string email, string mobile, string orderItem)
        {
            Console.WriteLine("Order Placed for : " + orderItem);
            if (OnCreated != null)
            {
                OnCreated(this,new OrderEventArgs(){ Email = email, Mobile = mobile });
            }
        }
    }
}

    
