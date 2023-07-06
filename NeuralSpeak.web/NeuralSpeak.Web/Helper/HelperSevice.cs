using System.Net.Http;
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
            //request.Headers.Add("Ocp-Apim-Subscription-Key", "a6cf9b866ee640cca1e58c23c138a702");
            request.Headers.Add("Ocp-Apim-Subscription-Key", "862c2f7c4eaf4ef4aeb8229d7b971fc4");
            var content = new StringContent(string.Empty);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return result;
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
            Console.WriteLine(await response.Content.ReadAsStringAsync());
            return response;
        }
    }
}
