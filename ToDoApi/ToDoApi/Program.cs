using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ToDoApi
{
    class Program
    {
        //create a new httpClient which is going to be used to get the response from our api. It will respond with all
        //available users

        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.GetAllUsers();
        }

        public async Task GetAllUsers()
        {
            string response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");
            Console.WriteLine(response);
        }
    }
}
