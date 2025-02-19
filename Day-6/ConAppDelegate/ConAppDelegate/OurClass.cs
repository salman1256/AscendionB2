using System;
namespace ConAppDelegate
{
  public class OurClass
    {
        public static string Welcome(string name)
        {
           return "Welcome to Delegate Mr.\\Ms."+name;
        }
        public  string Display(string msg)
        {
            return "Here is message for you ." + msg;
        }
    }
}
