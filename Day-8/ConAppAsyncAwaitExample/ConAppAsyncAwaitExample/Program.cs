//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
////The async keyword is used to mark a method as asynchronous, 
////    while the await keyword is used to temporarily suspend the execution of an async method 
////    and yield control back to the calling method until the awaited task is completed.
//namespace ConAppAsyncAwaitExample
//{  public  class Program
//    {
//        public static async Task<string> DownloadPage(string url)
//        {
//            using (var httpClient = new HttpClient())
//            {
//                return await httpClient.GetStringAsync(url);

//            };
//        }
//        public static void ProcessPages(List<string> urls)
//        {
//            Parallel.ForEach(urls, url =>
//            {
//                string page = DownloadPage(url).Result;
//                Console.WriteLine($"Downlaoded {url}. Web Page Length is {page.Length} chars");
//            });
//        }

//           static void Main(string[] args)
//        {
//            List<string> urls = new List<string>()
//                            {  "https://www.thehindu.com/",
//                            "https://www.espncricinfo.com/",
//                            "https://www.bbc.com/hindi",
//                            "https://ascendion.com/"

//                            };
//            Console.WriteLine("Download Urls are processing");
//            var startTime = DateTime.Now;
//            ProcessPages(urls);
//            var endTime = DateTime.Now;
//            Console.WriteLine($"Time Taken : Start Time was {startTime} and End Time was {endTime}");
//            Console.ReadKey();
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ConAppTPL
{
    internal class Program
    {
        public static string DownloadPage(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return httpClient.GetStringAsync(url).Result; // Synchronously wait for the result
            }
        }

        public static void ProcessPages(List<string> urls)
        {
            foreach (var url in urls)
            {
                string page = DownloadPage(url);
                Console.WriteLine($"Downloaded {url}. Web Page Length is {page.Length} chars");
            }
        }

        static void Main(string[] args)
        {
            List<string> urls = new List<string>()
            {
                "https://www.thehindu.com/",
                "https://www.espncricinfo.com/",
                "https://www.bbc.com/hindi",
                "https://ascendion.com/",
            };

            Console.WriteLine("Download URLs are processing");
            var startTime = DateTime.Now;
            ProcessPages(urls);
            var endTime = DateTime.Now;
            Console.WriteLine($"Time Taken: Start Time was {startTime} and End Time was {endTime}");
            Console.ReadKey();
        }
    }
}
