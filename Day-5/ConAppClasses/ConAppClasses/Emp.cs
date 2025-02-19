//using System;
//namespace ConAppClasses
//{//[AS][Mod]DataType PropertyName {get {return } set {value}}
//    //get: reading
//    //set:writing
//    //1.ReadOnly  //get
//    //2.WriteOnly //set
//    //3.Read&Write //get, set
//    //4.Abstract  
//    //5.AutoImplemented 
//    //6.Static
//    public class Emp
//    {
//        int id;
//        string name;
//        double salary;
//        public Emp()
//        {
//            Console.WriteLine("Emp Constructor Call");
//            id = 0;
//            name = "not given";
//            salary = 0;
//        }
//        public  int Id { get { return id; } set{ id = value; } }
//        public string Name { get { return name; } set { name = value; } }
//        public double Salary{ get { return salary; } set { salary = value; } }

//    }
//}

//using System;
//namespace ConAppClasses
//{//[AS][Mod]DataType PropertyName {get {return } set {value}}
//    //get: reading
//    //set:writing
//    //1.ReadOnly  //get
//    //2.WriteOnly //set
//    //3.Read&Write //get, set
//    //4.Abstract  
//    //5.AutoImplemented 
//    //6.Static
//    public class Emp
//    {
//        int id;
//        string name;
//        double salary;
//        public Emp()
//        {
//            Console.WriteLine("Emp Constructor Call");
//            id = 0;
//            name = "not given";
//            salary = 0;
//        }
//        public int Id { get { return id; } set { id = value; } }
//        public string Name 
//        {       get {
//                if (name == "invalid name")
//                {
//                    Console.WriteLine("Name must have 6 characters");
//                }
//                return name; }
//            set 
//            {   if (value.Length <= 6)
//                {
//                    name = "invalid name";

//                }
//                else 
//                {
//                    name = value;
//                }


//            } 
//        }
//        public double Salary { get { return salary; } set { salary = value; } }

//    }
//}

using System;
namespace ConAppClasses
{
    public class Emp
    {    int id;
        string name;
        double salary;
        static int noe=0;
        public Emp()
        {   Console.WriteLine("Emp Constructor Call");
            id = 0;
            name = "not given";
            salary = 50000.67;
            noe++;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Name
        {
            get
            { if (name == "invalid name")
                { Console.WriteLine("Name must have 6 characters");    }
                return name;
            }
            set
            {
                if (value.Length <= 6)
                { name = "invalid name";

                }
                else
                {  name = value;
                }


            }
        }
        public double Salary { get { return salary; } set { salary = value; } }
        public static int Noe { get { return noe; } }

    }
}
