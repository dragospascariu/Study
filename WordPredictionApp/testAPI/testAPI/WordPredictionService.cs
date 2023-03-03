using Newtonsoft.Json;
using System.Net.Http.Headers;


namespace WordPrediction.Service
{
    public class WebPredictionService
    {
        public async Task<dynamic> GetWizkidsWordPrediction(string input, string locale)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, $"https://services.lingapps.dk/misc/getPredictions?locale={locale}&text={input}"))
            {
                string Token = "MjAyMi0wMS0yNw==.cGFzZHJhZ29zQHlhaG9vLmNvbQ==.YjIyNTg0YjExZTIxYmVhMWY5NzZkZjYzODk3NzE4YWU=";
                HttpClient client = new HttpClient();
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic data = JsonConvert.DeserializeObject<dynamic>(responseBody);
                return data;
            }
        }
    }
}
