using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{



    internal class UrlsQuery
    {


        public string[] urls = new string[]
        {

        "https://tap.az/",
        "https://autonet.az/",
        "https://tap.az/",
        "https://lalafo.az/",
        "https://translate.google.com/",
        "https://www.aztu.edu.az/az"
        };






        public void GetHttpContent(string[] url)
        {
            HttpClient httpClient = new HttpClient();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (var itme in url)
            {
                var result = httpClient.GetStringAsync(itme).Result;
                Console.WriteLine(result.Length);
            }
            stopwatch.Stop();
            Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms");
        }



        public  async Task GetHttpContentAsync(string[] url)
        {
            HttpClient httpClient = new HttpClient();
            List<Task<string>> list = new List<Task<string>>();
            Stopwatch stopwatch = new Stopwatch();
            
            foreach (var itme in url)
            {
                var result = httpClient.GetStringAsync(itme);
                list.Add(result);
            }
            stopwatch.Start();
            string[] arr = await Task.WhenAll(list);

            foreach (var item in arr)
            {
                Console.WriteLine(item.Length);
            }
            stopwatch.Stop();
            Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms");

        }
    }
}
