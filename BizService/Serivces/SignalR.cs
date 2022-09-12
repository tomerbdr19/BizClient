using System;
using System.Text;
using System.Threading.Tasks;

namespace BizService.Services
{
    public class SignalR
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task StoreId(string Id, string ConnectionId)
        {
            var contentString = JsonConvert.SerializeObject(new { UserId = Id, ConnectionId });
            var content = new StringContent(contentString, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("http://10.0.2.2:7071/api/connect", content);
            return;
        }
    }

    public class NegotiateResponse
    {
        public string AccessToken { get; set; }
        public string Url { get; set; }
    }
}

