using System;
namespace ConAppAbstractEx
{
    public class OurDriveClass : OurAb
    {
        string msg;
        public OurDriveClass()
        {
            msg = "I am from OurDrive Class";
        }
        public override string OurAbProp 
        { get => msg; set => msg=value; }

        public override void Display()
        {
            Console.WriteLine
                ("Display Method of OurDrive Class");
        }
    }
}
