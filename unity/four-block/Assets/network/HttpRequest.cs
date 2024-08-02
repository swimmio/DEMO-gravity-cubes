using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace network
{
    public class HttpGetRequest : IHttpRequest
    {
        private static readonly HttpClient Client = new HttpClient();

        public async Task<string> ExecuteAsync(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
    
    public class HttpPostRequest : IHttpRequest
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<string> ExecuteAsync(string url)
        {
            var content = new StringContent("", Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}