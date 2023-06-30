using System.Net.Http.Headers;

namespace NeuralSpeak.Web.Helper
{
    public class HelperSevice
    {
        public async Task<string> getAuthToken()
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build();
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://eastasia.api.cognitive.microsoft.com/sts/v1.0/issueToken");
            request.Headers.Add("Ocp-Apim-Subscription-Key", "a6cf9b866ee640cca1e58c23c138a702");
            var content = new StringContent(string.Empty);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return result;

        }
    }
}
