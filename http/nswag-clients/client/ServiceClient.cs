using Kenny;

namespace client
{
    public class ServiceClient : IServiceClient
    {
        private readonly HttpClient _httpClient;

        public ServiceClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetExample(string userName)
        {
            var result = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, $"api/Hello/{userName}/example"));

            return await result.Content.ReadAsStringAsync();
        }
    }
}