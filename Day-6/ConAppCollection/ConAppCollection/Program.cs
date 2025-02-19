//using System;
//using System.Collections;
//namespace ConAppCollection
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //var myVar = 'A';
//            //var myVar2 = 12.45F;
//            //Console.WriteLine("Stored value: \t"+myVar +"DataType: \t"+myVar.GetType());
//            //Console.WriteLine("Stored value: \t" + myVar2 + "DataType: \t" + myVar2.GetType());
//            //ArrayList arrayList = new ArrayList()
//            //{
//            //    "Sam",
//            //    'A',
//            //    DateTime.Now,
//            //    12.45
//            //};
//            //Console.WriteLine("Number of elements in ArrayList: \t" + arrayList.Count);
//            //Console.WriteLine("Capacity of ArrayList: \t" + arrayList.Capacity);
//            //Console.WriteLine("***Element of ArrayList***");
//            //foreach (var item in arrayList)
//            //{
//            //    Console.WriteLine(item);
//            //}
//            ////
//            //arrayList.Add("Ajay");
//            //Console.WriteLine("Number of elements in ArrayList: \t" + arrayList.Count);
//            //Console.WriteLine("Capacity of ArrayList: \t" + arrayList.Capacity);
//            //Console.WriteLine("***Element of ArrayList***");
//            //foreach (var item in arrayList)
//            //{
//            //    Console.WriteLine(item);
//            //}
//            ////
//            //arrayList.Add("A");
//            //arrayList.Add("B");
//            //arrayList.Add("C");
//            //arrayList.Add("D");
//            //Console.WriteLine("Number of elements in ArrayList: \t" + arrayList.Count);
//            //Console.WriteLine("Capacity of ArrayList: \t" + arrayList.Capacity);
//            //Console.WriteLine("***Element of ArrayList***");
//            //foreach (var item in arrayList)
//            //{
//            //    Console.WriteLine(item);
//            //}
//            //Console.ReadKey();  

//            ArrayList studentList = new ArrayList() { "Raj", "Anita", "Zoya", "Vidhu", "Gaurav" };
//            Console.WriteLine("Number of Students "+studentList.Count);
//            foreach(var n in studentList) 
//            { 
//                Console.WriteLine(n);
//            }
//            studentList.Sort();
//            Console.WriteLine("Sorted List");
//            foreach (var n in studentList)
//            { Console.WriteLine(n);
//            }
//            studentList.Reverse();
//            Console.WriteLine("Sorted List in Descending Order");
//            foreach (var n in studentList)
//            {   Console.WriteLine(n);
//            }
//            studentList.Remove("Raj");
//            Console.WriteLine("Studetn List after Removing Raj Number of Student \t"+studentList.Count);
//            foreach (var n in studentList)
//            {
//                Console.WriteLine(n);
//            }

//            studentList.RemoveAt(1);
//            Console.WriteLine("Studetn List after Removing from index 1 \t" + studentList.Count);
//            foreach (var n in studentList)
//            {
//                Console.WriteLine(n);
//            }
//            studentList.Clear();
//            Console.WriteLine("Studetn List after Clear \t" + studentList.Count);
//            foreach (var n in studentList)
//            {
//                Console.WriteLine(n);
//            }
//            Console.WriteLine("Enter stuent name to add in student List");
//             string name=Console.ReadLine();
//            studentList.Add(name);
//            Console.WriteLine("Studetn List after Adding \t" + studentList.Count);
//            foreach (var n in studentList)
//            {
//                Console.WriteLine(n);
//            }
//            Console.ReadKey();

//        }
//    }
//}

//HashTable
using System;
using System.Collections;
using System.ComponentModel;
namespace ConAppCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hashtable ht = new Hashtable()
            //{
            //    {"hdd","Hard Disc" },
            //    { "ram","Randome Access Memory"},
            //    {"cd","Compact Disc" },
            //    {"kb","Kilo Bytes" }
            //};
            //Console.WriteLine("Stored values Count: \t"+ht.Count);
            //Console.WriteLine("Keys");
            //foreach (var k in ht.Keys)
            //{
            //    Console.WriteLine(k);

            //}
            //Console.WriteLine("Values");
            //foreach (var v in ht.Values)
            //{
            //    Console.WriteLine(v);

            //}
            //Console.WriteLine("Key \t Value");
            //foreach (var k in ht.Keys)
            //{
            //    Console.WriteLine(k + "\t\t" + ht[k]);

            //}
            //Console.ReadKey();

            //Hashtable ht = new Hashtable()
            //{
            //    {1,"Hard Disc" },
            //    {2,"Head Phone" },
            //    {5,"Ear Buds" },
            //    {6,"Key Board" },
            //    {3,"EarPhones" },
            //};
            //Console.WriteLine("Stored values Count: \t" + ht.Count);
            //Console.WriteLine("Keys");
            //foreach (var k in ht.Keys)
            //{
            //    Console.WriteLine(k);

            //}
            //Console.WriteLine("Values");
            //foreach (var v in ht.Values)
            //{
            //    Console.WriteLine(v);

            //}
            //Console.WriteLine("Key \t Value");
            //foreach (var k in ht.Keys)
            //{
            //    Console.WriteLine(k + "\t\t" + ht[k]);

            //}
            //Console.ReadKey();

            //SortedList sortedList = new SortedList()
            //{
            //    {1,"Hard Disc" },
            //    {2,"Head Phone" },
            //    {5,"Ear Buds" },
            //    {6,"Key Board" },
            //    {3,"EarPhones" },
            //};
            //Console.WriteLine("Stored values Count: \t" + sortedList.Count);
            //Console.WriteLine("Keys");
            //foreach (var k in sortedList.Keys)
            //{
            //    Console.WriteLine(k);

            //}
            //Console.WriteLine("Values");
            //foreach (var v in sortedList.Values)
            //{
            //    Console.WriteLine(v);

            //}
            //Console.WriteLine("Key \t Value");
            //foreach (var k in sortedList.Keys)
            //{
            //    Console.WriteLine(k + "\t\t" + sortedList[k]);

            //}
            //Console.ReadKey();
            //Stack Example
            //Stack stack = new Stack();
            //stack.Push("Amit");
            //stack.Push("Ira");
            //stack.Push("Gagan");
            //Console.WriteLine("Stored Values: \t"+stack.Count);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Pop result: \t "+stack.Pop());
            //Console.WriteLine("Stored Values: after Pop \t" + stack.Count);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Peek result: \t " + stack.Peek());
            //Console.WriteLine("Stored Values: after Peek \t" + stack.Count);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //Queue Example
            Queue queue = new Queue();
            queue.Enqueue("Amit");
            queue.Enqueue("Ira");
            queue.Enqueue("Gagan");
            Console.WriteLine("Stored Values: \t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Dequeue result: \t " + queue.Dequeue());
            Console.WriteLine("Stored Values: Dequeue Pop \t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek result: \t " + queue.Peek());
            Console.WriteLine("Stored Values: after Peek \t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Clear();
            Console.WriteLine("After Clear" + queue.Count);
            Console.ReadKey();
        }
    }
}