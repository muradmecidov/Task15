using ConsoleApp12.Models;

namespace ConsoleApp12
{
    internal class Program
    {
        static async void Main(string[] args)
        { 
            UrlsQuery urlsQuery = new UrlsQuery();
            urlsQuery.GetHttpContent(urlsQuery.urls);
            urlsQuery.GetHttpContentAsync(urlsQuery.urls);



        }
    }
}