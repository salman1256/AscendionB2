//using System;
//namespace GenericExample
//{
//   public class OurGen<T>
//    {
//        T ourField;
//        public OurGen(T ourParam)
//        {
//            ourField = ourParam;
//        }
//        public void Display()
//        {
//            Console.WriteLine
//            ("Stored Value: \t"+ourField
//            +"\t DataType: \t"+ourField.GetType());
//        }
//    }
//}

using System;
namespace GenericExample
{
    public class OurGen<T,U> where T : class where U : struct
    {
        T ourField1;
        U ourField2;
        public OurGen(T ourField1,U ourField2)
        {
            this.ourField1 = ourField1;
            this.ourField2 = ourField2; 
        }
        public void Display()
        {
            Console.WriteLine("Stored Value in: FieldOne\t" + ourField1+ "\t DataType: \t" + ourField1.GetType());
            Console.WriteLine("Stored Value in: FieldTwo\t" + ourField2 + "\t DataType: \t" + ourField2.GetType());
        }
    }
}
