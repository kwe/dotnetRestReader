using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Post post = new Post();
            HttpClient client = new HttpClient();
            var json = GetApi(client).Result;
            
            JArray p = JArray.Parse(json);

        }
        static async Task<string> GetApi(HttpClient c)
        {
            
            var r = await c.GetStringAsync("http://localhost:8000/wp-json/wp/v2/posts");
            return r;
        }
    }
}
