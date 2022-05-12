using System;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    class Program {
        static async Task Main(string[] args) {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");

            // await Login(client);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer 1|3z2JFu8SzmL07SIjjNje7GKc6ApcQrO9fGURtL50");
            await userInfo(client);
            //var x = await client.GetAsync("http://178.62.201.95");
            //Console.WriteLine(x.StatusCode);
        }
        public static async Task userInfo(HttpClient client) {
            var req = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://178.62.201.95/api/user")
                //Content = new StringContent("{\"email\": \"k@gmail.com\", \"password\": \"123456789\", \"api_key\": \"eyJhbGciOiJIUzM4NCIsInR5cCI6IkpXVCIsImFwcCI6InRpY2NrZXQiLCJjcmVhdG9yIjoia2FyZWVtIEVsLUdpdXNoeSJ9\"}", Encoding.UTF8, MediaTypeNames.Application.Json)

            };

            var resp = await client.SendAsync(req).ConfigureAwait(false);
            Console.WriteLine(await resp.Content.ReadAsStringAsync());
        }
        public static async Task Login(HttpClient client) {
            var req = new HttpRequestMessage {
                Method = HttpMethod.Post,
                RequestUri = new Uri("http://178.62.201.95/api/login"),
                Content = new StringContent("{\"email\": \"k@gmail.com\", \"password\": \"123456789\", \"api_key\": \"eyJhbGciOiJIUzM4NCIsInR5cCI6IkpXVCIsImFwcCI6InRpY2NrZXQiLCJjcmVhdG9yIjoia2FyZWVtIEVsLUdpdXNoeSJ9\"}", Encoding.UTF8, MediaTypeNames.Application.Json)

            };

            var resp = await client.SendAsync(req).ConfigureAwait(false);
            Console.WriteLine(await resp.Content.ReadAsStringAsync());
        }
        public static async Task Register(HttpClient client) {
            var req = new HttpRequestMessage {
                Method = HttpMethod.Post,
                RequestUri = new Uri("http://178.62.201.95/api/register"),
                Content = new StringContent("{\"name\": \" kareem\", \"email\": \"k@gmail.com\", \"password\": \"123456789\", \"re_password\": \"123456789\", \"api_key\": \"eyJhbGciOiJIUzM4NCIsInR5cCI6IkpXVCIsImFwcCI6InRpY2NrZXQiLCJjcmVhdG9yIjoia2FyZWVtIEVsLUdpdXNoeSJ9\"}", Encoding.UTF8, MediaTypeNames.Application.Json)

            };
            Console.WriteLine(req.Content);
            var resp = await client.SendAsync(req).ConfigureAwait(false);

            Console.WriteLine(await resp.Content.ReadAsStringAsync());
        }
    }
}
