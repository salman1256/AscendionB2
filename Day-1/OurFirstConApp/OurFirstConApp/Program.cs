using System;

namespace OurFirstConApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start 
            //Console.WriteLine("Welcome to C#");
            //Console.Write("Welcome to C#  One more Time");
            //Console.Write("Welcome to C# Again");
            //Console.ReadKey();
            //DataType VariableName;
            //string userName;
            //Console.WriteLine("Enter User Name");
            //userName = Console.ReadLine();
            //Console.WriteLine("Welcome Mr.\\Ms. "+userName);
            //Console.ReadKey();
            //Example-2
            //  string fname, lname;
            //  char grade;
            //  double fee;
            //  Console.WriteLine("Enter Student\'s First Name");
            //  fname = Console.ReadLine();
            //  Console.WriteLine("Enter Student\'s Last Name");
            //  lname = Console.ReadLine();
            //  Console.WriteLine("Enter Grade");
            //  //DataType.Parse()
            //  grade=char.Parse(Console.ReadLine());
            //  Console.WriteLine("Enter Fee ");
            //  //DataType.Parse()
            //  fee = double.Parse(Console.ReadLine());
            //  Console.WriteLine("Student details as follows");
            //  Console.WriteLine($"Full Name : \t {fname} {lname} \n Grade:\t {grade} \n Fee: \t {fee}");

            //  Console.WriteLine("Welcome {1} \n First Name :\t {0} \n Last Name:\t {1} \n Grade:\t {2} \n Fee: \t {3}"
            //      ,fname,lname,grade,fee);
            //Console.WriteLine("First Name :\t"+fname+" \n Last Name:\t "+lname +"\n Grade:\t" +grade+"\n Fee: \t"+fee);
            //  Console.ReadKey();
            int num;
            string choice;
            do
            {
                Console.WriteLine("Enter a number to findout table");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Table of {num}");
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{num} * {i} =\t {num * i}");
                }

                Console.WriteLine("Do You wanna continue... if yes press y");
                choice = Console.ReadLine();
            } while (choice.ToLower()=="y");


        }
    }
}
