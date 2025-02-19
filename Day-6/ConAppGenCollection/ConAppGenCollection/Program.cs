using System;
using System.Collections.Generic;

namespace ConAppGenCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>()
            //{
            //    "Amit",
            //    "Sam",
            //    "Zoya",
            //    "Rohan",
            //    "Vinit",

            //};
            //Console.WriteLine("Number of items: \t"+list.Count);
            //Console.WriteLine("Capacity \t" + list.Capacity);
            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //list.Add("Rohit");list.Add("Deep"); list.Add("Neha");list.Add("Zen");list.Add("Noyan");
            //Console.WriteLine("After adding more items");
            //Console.WriteLine("Number of items: \t" + list.Count);
            //Console.WriteLine("Capacity \t" + list.Capacity);
            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Enter name to search from list");
            //string name=Console.ReadLine();
            //if(list.Contains(name)) 
            //{
            //    Console.WriteLine("Find at index \t"+list.IndexOf(name));
            //}
            //else
            //{
            //    Console.WriteLine("No Such Name \t "+name +"\t exist in List");
            //}
            //Console.ReadKey();
            //Console.WriteLine("Dictionary Example");
            //Dictionary<int, string> dictionary = new Dictionary<int, string>()
            //{    { 1, "Digital Camera" },
            //    { 2, "Ear Phone" },
            //    { 5, "Laptop" },
            //    { 3, "IPhone" },
            //    { 4, "Washing Machine" }
            //};
            //foreach (var product in dictionary)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine("Key \t Value");
            //foreach (var k in dictionary.Keys)
            //{
            //    Console.WriteLine(k + "\t" + dictionary[k]);
            //}
            //Console.WriteLine("Sorted List Example");
            //SortedList<int, string> productsList = new SortedList<int, string>()
            //{   { 1, "Digital Camera" },      { 2, "Ear Phone" },   { 5, "Laptop" },  { 3, "IPhone" },
            //    { 4, "Washing Machine" }
            //};
            //foreach (var product in productsList)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine("Key \t Value");
            //foreach (var k in productsList.Keys)
            //{
            //    Console.WriteLine(k + "\t" + productsList[k]);
            //}
            //Console.ReadKey();
            //HashSet<string> set = new HashSet<string>()
            //{
            //    "Amit",
            //    "Vijay",
            //    "Nitin",
            //    "Amit",
            //    "Gauri"
            //};

            //Console.WriteLine("Number of Elements in HashSet\t "+set.Count);
            //foreach (string s in set)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.ReadKey();  

            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 5 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            // Union of two sets
            set1.UnionWith(set2);
            Console.WriteLine("After Union: "
                              + string.Join(", ", set1));

            // Intersection of two sets
            set1.IntersectWith(new HashSet<int> { 3, 5 });
            Console.WriteLine("After Intersection: "
                              + string.Join(", ", set1));

            // Difference of sets
            set1.ExceptWith(new HashSet<int> { 5 });
            Console.WriteLine("After Difference: "
                              + string.Join(", ", set1));
            Console.ReadKey();
        }
    }
}
