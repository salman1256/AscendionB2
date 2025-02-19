using System;
namespace ConAppAutoImplementeProEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product()
            //{
            //    PId = 1,
            //    PName = "Organic Shampoo",
            //    PPrice = 560.56,
            //    MfgDate = new DateTime(day: 12, month: 1, year: 2025)
            //};
            //Console.WriteLine("Product Details as follows");
            //Console.WriteLine("Product Id : \t"+product.PId);
            //Console.WriteLine("Product Name: \t" + product.PName);
            //Console.WriteLine("Product Price: \t" + product.PPrice);
            //Console.WriteLine("Product MfgDate: \t" + product.MfgDate);
            //Console.ReadKey();
            Product.GST = 0.18;
            Product product1 = new Product();
            Console.WriteLine("Enter Product ID");
            product1.PId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            product1.PName= Console.ReadLine();
            Console.WriteLine("Enter Product PPrice");
            product1.PPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product MfgDate");
            product1.MfgDate = DateTime.Parse(Console.ReadLine());
            Product product2 = new Product()
            {
                PId = 1,
                PName = "Organic Shampoo",
                PPrice = 560.56,
                MfgDate = new DateTime(day: 12, month: 1, year: 2025)
            };
            Console.WriteLine("Product One Details as follows");
           
            Console.WriteLine("Product Id : \t" + product1.PId);
            Console.WriteLine("Product Name: \t" + product1.PName);
            Console.WriteLine("Product Price: \t" + product1.PPrice);
            Console.WriteLine("Product MfgDate: \t" + product1.MfgDate.ToShortDateString());
            Console.WriteLine("Product GST: \t" + (product1.PPrice* Product.GST));

            Console.WriteLine("Product Two Details as follows");

            Console.WriteLine("Product Id : \t" + product2.PId);
            Console.WriteLine("Product Name: \t" + product2.PName);
            Console.WriteLine("Product Price: \t" + product2.PPrice);
            Console.WriteLine("Product MfgDate: \t" + product2.MfgDate.ToShortDateString());
            Console.WriteLine("Product GST: \t" + (product2.PPrice * Product.GST));
            Console.ReadKey();



        }
    }
}
