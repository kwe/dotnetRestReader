using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public string Response { get; set; }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Post post = new Post();
            HttpClient client = new HttpClient();
            post = GetApi(client).Result;

        }
        static async Task<Post> GetApi(HttpClient c)
        {
            Post post = new Post();
            
            var r = await c.GetStringAsync("http://localhost:8000/wp-json/wp/v2/posts");
            
            post.Title = "Set in Task";
            post.Content = "Hey now";

            return post;
        }
    }
}
