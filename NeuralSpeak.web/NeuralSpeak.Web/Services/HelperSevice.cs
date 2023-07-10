using System.Net.Http.Headers;

namespace NeuralSpeak.Web.Services
{
    public class HelperSevice : IHelperSevice
    {
        private readonly IConfiguration _configuration;
        public HelperSevice(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<string> GetAuthToken()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, _configuration.GetValue<string>("AzureSpeechService:BaseUrl"));
            request.Headers.Add("Ocp-Apim-Subscription-Key", _configuration.GetValue<string>("AzureSpeechService:SubscriptionKey"));
            var content = new StringContent(string.Empty);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<object> UploadToAzure(StreamContent streamContent,string id)
        {
            var blobName = id + ".mp3";
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Put, "https://neuralspeakblob.blob.core.windows.net/speech-history/" + blobName + "?sv=2022-11-02&ss=bfqt&srt=o&sp=rwdlacupiytfx&se=2024-07-05T20:39:40Z&st=2023-07-05T12:39:40Z&spr=https,http&sig=GN8ZQrmNNcDwcqVsj6UqaYNXyEh1Wrgxcr%2F2BaHWCLY%3D");
            request.Headers.Add("x-ms-blob-type", "BlockBlob");
            request.Content = streamContent;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return response;
        }
    }

    public interface IHelperSevice
    {
        Task<string> GetAuthToken();
        Task<object> UploadToAzure(StreamContent streamContent, string id);
    }
}
