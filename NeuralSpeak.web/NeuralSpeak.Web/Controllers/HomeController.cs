using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NeuralSpeak.Web.Models;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace NeuralSpeak.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> TextToSpeechAsync()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var name = config["SubscriptionKey"];

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://eastasia.api.cognitive.microsoft.com/sts/v1.0/issueToken");
            //request.Headers.Add("Content-type", "application/x-www-form-urlencoded");
            //request.Headers.Add("Content-length", "0");            //request.Headers.Add("Content-type", "application/x-www-form-urlencoded");
            //request.Headers.Add("Content-length", "0");
            request.Headers.Add("Ocp-Apim-Subscription-Key", "a6cf9b866ee640cca1e58c23c138a702");
            var content = new StringContent(string.Empty);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            //Console.WriteLine(await response.Content.ReadAsStringAsync());
            ViewBag.token = await response.Content.ReadAsStringAsync();
            return View();
        }

        public IActionResult SpeechtoText()
        {
            return View();
        }

        public IActionResult SpeechToSpeech()
        {
            return View();
        }
        public IActionResult CustomVoice()
        {
            return View();
        }
    }
}