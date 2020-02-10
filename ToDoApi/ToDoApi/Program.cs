using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ToDoApi
{
    class Program
    {
        //create a new httpClient which is going to be used to get the response from our api. It will respond with all
        //ToDo items.

        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.GetAllToDoItems();
        }

        public async Task GetAllToDoItems()
        {
            string response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");
            Console.WriteLine(response);
        }
    }
}
