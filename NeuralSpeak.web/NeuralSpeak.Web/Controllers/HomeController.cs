using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NeuralSpeak.Web.Data.Entities;
using NeuralSpeak.Web.Models;
using NeuralSpeak.Web.Services;
using System.Diagnostics;
using System.Security.Claims;

namespace NeuralSpeak.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private readonly IHelperSevice _helperSevice;
        private readonly ILanguageServices _languageServices;
        private readonly IUserHistoryService _userHistoryService;

        public HomeController(IHelperSevice helperSevice, ILanguageServices languageServices, IUserHistoryService userHistoryService)
        {
            _helperSevice = helperSevice;
            _languageServices = languageServices;
            _userHistoryService = userHistoryService;
        }

        public async Task<IActionResult> Index()
        {
            List<UserAudioView> userHistoryList = await _userHistoryService.GetByUserId(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View(userHistoryList);
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

        public async Task<IActionResult> TextToSpeech()
        {
            ViewBag.token = await _helperSevice.GetAuthToken();
            await GetLanguage();
            return View();
        }

        public async Task<IActionResult> SpeechtoTex()
        {
            ViewBag.token = await _helperSevice.GetAuthToken();
            await GetLanguage();
            return View();
        }

        public async Task<IActionResult> SpeechToSpeech()
        {
            ViewBag.token = await _helperSevice.GetAuthToken();
            await GetLanguage();
            return View();
        }
        public async Task<IActionResult> CustomVoice()
        {
            ViewBag.token = await _helperSevice.GetAuthToken();
            await GetLanguage();
            return View();
        }

        public async Task<IActionResult> SpeechToTranslate()
        {
            ViewBag.token = await _helperSevice.GetAuthToken();
            await GetLanguage();
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

            await _userHistoryService.Add(new UserHistory()
            {
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                FileUrl = id,
                DestinationLanguage = "",
                SourceLanguage = "",
            });
            return Json(res);

        }

        [HttpGet]
        public async Task<ActionResult> DeleteAudio(int id)
        {
            var isDelete = await _userHistoryService.DeleteBy(id);
            if (isDelete)
            {
                return Json(new
                {
                    success = true,
                    message = "Audio Deleted Successfully"
                });
            }

            return Json(new
            {
                success = false,
                message = "Audio not found"
            });

        }

        private async Task GetLanguage()
        {
            ViewBag.token = await _helperSevice.GetAuthToken();
            List<Languages> languages = await _languageServices.GetLanguages();
            ViewBag.LanguagesDropDown = languages.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Code
            }).ToList();
            ViewBag.Languages = languages;
        }
    }
}