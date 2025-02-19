using System;
namespace ConAppInterface
{
    public class OurDrive : IOurInterface
    {
        int ourField;
        public OurDrive()
        {
            ourField = 12; 
        }
        public int MyProperty { get => ourField; set => ourField = value; }

        public void Display()
        {
            Console.WriteLine("Display Method of OurInterface");
        }
    }
}
