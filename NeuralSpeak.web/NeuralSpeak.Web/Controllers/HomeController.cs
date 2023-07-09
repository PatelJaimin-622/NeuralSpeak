using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            List<UserHistory> userHistoryList = _applicationDbContext.UserHistory.Where(x => x.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList();
            //var UserAudioViewList = _applicationDbContext.Users.Include(x=>x.UserHistory).Where(y => y.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));

            List<UserAudioView> model = new List<UserAudioView>();

            foreach (var userHistory in userHistoryList)
            {
                UserAudioView audioView = new UserAudioView
                {
                    // Map the properties from UserHistory to UserAudioView
                    UserHistoryId = userHistory.UserHistoryId,
                    UserId = userHistory.UserId,
                    FileUrl = userHistory.FileUrl,
                    CreatedDate = userHistory.CreatedDate,
                    SourceLanguage = userHistory.SourceLanguage,
                    DestinationLanguage = userHistory.DestinationLanguage,
                    // Add more properties as needed
                };

                model.Add(audioView);
            }

            return View(model);
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
        public async Task<IActionResult> CustomVoice()
        {
            ViewBag.token = await _helperSevice.getAuthToken();
            List<SelectListItem> selctLang = new List<SelectListItem>();
            foreach (var item in Languages.langList)
            {
                selctLang.Add(new SelectListItem { Text = item.Name, Value = item.Code});
            }
            ViewBag.langList = new SelectList(selctLang, "Value","Text");
            ViewBag.AlllangList = Languages.langList;
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

        [HttpGet]
        public async Task<ActionResult> DeleteAudio(int id)
        {
            var record = await _applicationDbContext.UserHistory.FindAsync(id);
            if (record != null)
            {
                _applicationDbContext.UserHistory.Remove(record);
                await _applicationDbContext.SaveChangesAsync();
                return Json(new
                {
                    success = true,
                    message = "Audio Deleted Successfully"
                });
            }
                      
            return Json(new
            {
                success = false,
                message = "audio not found"
            });

        }
    }
}