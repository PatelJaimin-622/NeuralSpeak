using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NeuralSpeak.Web.Helper;
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
        protected HelperSevice _helperSevice = new HelperSevice();

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
            ViewBag.token = await _helperSevice.getAuthToken();
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

        public async Task<IActionResult> SpeechToTranslate()
        {
            ViewBag.token = await _helperSevice.getAuthToken();
            return View();
        }
    }
}