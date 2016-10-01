using Microsoft.AspNetCore.Mvc;

namespace DemoMvcWebApi.Controllers
{
    public class SpeakerController : Controller
    {
        private readonly Services.ISpeakersService _speakersService;

        public SpeakerController(Services.ISpeakersService speakersService)
        {
            _speakersService = speakersService;
        }

        public IActionResult Index()
        {
            var speakers = _speakersService.GetSpeakers();
            return View(speakers);
        }

        public IActionResult Details(int id)
        {
            var speaker = _speakersService.GetSpeaker(id);
            return View(speaker);
        }
    }
}
