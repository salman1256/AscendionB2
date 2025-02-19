using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMulticast
{
    internal class Program
    {
        public delegate void OurDel();
        static void Main(string[] args)
        {
            OurGame cargame = new OurGame();
            OurDel objDel=new OurDel (cargame.Start);
            objDel();
            //....
            objDel += new OurDel(cargame.Jump);
            objDel += new OurDel(cargame.ExtraFuelTank);
            Console.WriteLine("After adding 2 more methods in Invocation list of Delegate");
            objDel();
            objDel += new OurDel(cargame.ExtraFuelTank);
            objDel += new OurDel(cargame.ExtraFuelTank);
            Console.WriteLine("After adding 5 methods in Invocation list of Delegate");
            objDel();
            objDel += new OurDel(cargame.Fly);
            Console.WriteLine("After adding 6 methods in Invocation list of Delegate");
            objDel();
            //.....
            objDel-=new OurDel(cargame.ExtraFuelTank);
            Console.WriteLine("After Removing one ExtraFuelTank");
            objDel();

            //
            objDel -= new OurDel(cargame.Fly);
            objDel -= new OurDel(cargame.ExtraFuelTank);
            Console.WriteLine("After Removing two ExtraFuelTank and Fly");
            objDel();

            Console.ReadKey();  
        }
    }
}
