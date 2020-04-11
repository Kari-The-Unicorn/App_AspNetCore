using System;
using System.Net.Http;

namespace ConsoleApp_AspNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            GetData();
            Console.ReadLine();
            Console.ReadKey();
        }
        static async void GetData()
        {
            //Make a GET request
            HttpClient client = new HttpClient();
            //Receive a GET response
            HttpResponseMessage response = await client
                .GetAsync("https://www.dallasopendata.com/resource/7e48-gxg9.json");
            response.EnsureSuccessStatusCode();
            string data = await response.Content.ReadAsStringAsync();
            Console.WriteLine(data);
        }
    }
}
