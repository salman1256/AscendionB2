// See https://aka.ms/new-console-template for more information
using ConAppEFCoreDbFirst.Models;

Console.WriteLine("Welcome to Customers App");
try {
    CustomersDbContext db = new CustomersDbContext();
    foreach (var c in db.Customers)
    {
        Console.WriteLine("Customer Id: \t" + c.Id);
        Console.WriteLine("First Name: \t" + c.Fname);
        Console.WriteLine("Last Name: \t" + c.Lname);
        Console.WriteLine("Plan Monthly \t" +c.Mplan);
        Console.WriteLine("Start Date \t" + c.Msdate);
        Console.WriteLine("End Date \t" + c.Medate);
        Console.WriteLine("-----------------------------------------------------");
    }
}
catch(Exception ex) { Console.WriteLine("Error!!!"+ex.Message); }
finally { Console.ReadKey(); }
