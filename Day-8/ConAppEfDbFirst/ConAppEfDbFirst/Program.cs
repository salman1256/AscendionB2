//Create
//using System;
//namespace ConAppEfDbFirst
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            try
//            {
//                CustomersDbEntities db = new CustomersDbEntities();
//                Customer customer = new Customer();
//                Console.WriteLine("Customer Id");
//                customer.Id=int.Parse(Console.ReadLine());
//                Console.WriteLine("First Name");
//                customer.Fname = Console.ReadLine();
//                Console.WriteLine("Last Name");
//                customer.Lname = Console.ReadLine();
//                Console.WriteLine("Plan Value");
//                customer.MPlan= double.Parse(Console.ReadLine());
//                Console.WriteLine("Start date");
//                customer.MSDate = DateTime.Parse(Console.ReadLine());
//                Console.WriteLine("End Date");
//                customer.MEDate= DateTime.Parse(Console.ReadLine());
//                db.Customers.Add(customer);
//                db.SaveChanges();
//               //db.SaveChangesAsync();
//                Console.WriteLine("***Record Inserted***");

//            }
//            catch (Exception ex) { Console.WriteLine("Error!!!" + ex.Message); }
//            finally { Console.ReadKey(); }
//        }
//    }
//}

//Read
//using System;
//namespace ConAppEfDbFirst
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            CustomersDbEntities db=new CustomersDbEntities();

//            try {
//                foreach(var c in db.Customers) 
//                {
//                    Console.WriteLine("Customer Id: \t"+c.Id);
//                    Console.WriteLine("First Name: \t" + c.Fname);
//                    Console.WriteLine("Last Name: \t" + c.Lname);
//                    Console.WriteLine("Plan Monthly \t" + c.MPlan);
//                    Console.WriteLine("Start Date \t" +((DateTime) c.MSDate).ToShortDateString());
//                    Console.WriteLine("End Date \t" + ((DateTime)c.MEDate).ToShortDateString());
//                    Console.WriteLine("-----------------------------------------------------");

//                }
//            }
//            catch(Exception ex) { Console.WriteLine("Error!!!"+ex.Message); }
//            finally { Console.ReadKey(); }
//        }
//    }
//}

//Search and Delete
//using System;
//using System.Linq;
//namespace ConAppEfDbFirst
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            try
//            {
//                CustomersDbEntities db = new CustomersDbEntities();
//                Console.WriteLine("Enter Customer Id to find out Customer Details");
//                int id =int.Parse(Console.ReadLine());
//                Customer customer = db.Customers.SingleOrDefault(x => x.Id == id);
//                if(customer == null)
//                {
//                    Console.WriteLine($"No Such Id {id} exist in customers");
//                }
//                else
//                {    Console.WriteLine("Record Found Details as follows ");
//                    Console.WriteLine("Customer Id: \t" + customer.Id);
//                    Console.WriteLine("First Name: \t" + customer.Fname);
//                    Console.WriteLine("Last Name: \t" + customer.Lname);
//                    Console.WriteLine("Plan Monthly \t" + customer.MPlan);
//                    Console.WriteLine("Start Date \t" + ((DateTime)customer.MSDate).ToShortDateString());
//                    Console.WriteLine("End Date \t" + ((DateTime)customer.MEDate).ToShortDateString());

//                }


//            }
//            catch (Exception ex) { Console.WriteLine("Error!!!" + ex.Message); }
//            finally { Console.ReadKey(); }
//        }
//    }
//}

//using System;
//using System.Linq;
//namespace ConAppEfDbFirst
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            try
//            {
//                CustomersDbEntities db = new CustomersDbEntities();
//                Console.WriteLine("Enter Customer Id to delete");
//                int id = int.Parse(Console.ReadLine());
//                Customer customer = db.Customers.SingleOrDefault(x => x.Id == id);
//                if (customer !=null)
//                {
//                    db.Customers.Remove(customer); 
//                    db.SaveChangesAsync();
//                    Console.WriteLine("Record Deleted!!!");
//                }
//                else
//                {
//                    Console.WriteLine($"No Such Id {id} exist in customers");


//                }


//            }
//            catch (Exception ex) { Console.WriteLine("Error!!!" + ex.Message); }
//            finally { Console.ReadKey(); }
//        }
//    }
//}

//Update

using System;
using System.Linq;
namespace ConAppEfDbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {   CustomersDbEntities db = new CustomersDbEntities();
                Console.WriteLine("Enter Id to update Customer");
                int id=int.Parse(Console.ReadLine());
                Customer extcustomer=db.Customers.SingleOrDefault(x => x.Id == id);
                if (extcustomer == null)
                {
                    Console.WriteLine($"No Such Customer Id {id} exist");
                }
                else
                {   Console.WriteLine("Enter New First Name");
                    extcustomer.Fname = Console.ReadLine();
                    Console.WriteLine("Enter New Last Name");
                    extcustomer.Lname = Console.ReadLine();
                    Console.WriteLine("Enter New Plan Value");
                    extcustomer.MPlan = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter New Start date");
                    extcustomer.MSDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter New End Date");
                    extcustomer.MEDate = DateTime.Parse(Console.ReadLine());
                    db.SaveChanges();
                    Console.WriteLine("***Record Updated***");
                }

            }
            catch (Exception ex) { Console.WriteLine("Error!!!" + ex.Message); }
            finally { Console.ReadKey(); }
        }
    }
}