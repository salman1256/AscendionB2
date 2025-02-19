using System;
namespace ConAppInheritance
{
    //public sealed class AppDev:Dev
    // {
    public  class AppDev : Dev
    {
        string osType;
        public AppDev()
        {
            Console.WriteLine("App Developer Constructor");
            osType = "unknown";
        }
        public sealed override void Display()
        {
            base.Display();
            Console.WriteLine("Operating System Type: \t"+osType);
        }
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter OS Type");
            osType= Console.ReadLine();
        }
    }
}
