using System;
using System.Runtime.InteropServices;

namespace ConAppAbstractEx
{
   public abstract class OurAb
    {
        int pField;
     
        public OurAb()
        {           
            Console.WriteLine("Constructor of Abstract Class");
            pField = 0;
        }
        public abstract void Display();
        public void Welcome(string name)
        {
            Console.WriteLine("Welcome to abstract Class Mr.\\Ms. "+name);
           
        }
        public abstract string OurAbProp { get; set; }
        public int AbProp { get { return pField; } set { pField = value; } 
        }
    }
}
