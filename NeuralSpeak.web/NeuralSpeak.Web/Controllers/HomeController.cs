using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NeuralSpeak.Web.Data;
using NeuralSpeak.Web.Data.Entities;
using NeuralSpeak.Web.Helper;
using NeuralSpeak.Web.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace NeuralSpeak.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected HelperSevice _helperSevice = new HelperSevice();
        private readonly ApplicationDbContext _applicationDbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _applicationDbContext = applicationDbContext;
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

        public async Task<IActionResult> SpeechToSpeech()
        {
            ViewBag.token = await _helperSevice.getAuthToken();
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


        [HttpPost]
        public async Task<ActionResult> UploadToAzureStorage(string id)
        {
            var memoryStream = new MemoryStream();
            await Request.Body.CopyToAsync(memoryStream);
            byte[] data = memoryStream.ToArray();
            var blob = new MemoryStream(data);
            StreamContent streamContent = new StreamContent(blob);

            var res = await _helperSevice.UploadToAzure(streamContent, id);

            _applicationDbContext.UserHistory.Add(new UserHistory()
            {
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                FileUrl = id,
                DestinationLanguage = "",
                SourceLanguage = "",
            });
            await _applicationDbContext.SaveChangesAsync();


            return Json(res);

        }
    }
}