using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvcWebApi.ApiControllers
{
    [Route("api/[controller]")]
    public class SpeakersController : Controller
    {
        private readonly Services.ISpeakersService _speakersService;

        public SpeakersController(Services.ISpeakersService speakersService)
        {
            _speakersService = speakersService;
        }

        // GET: api/speakers
        [HttpGet]
        public IEnumerable<Models.Speaker> Get()
        {
            return _speakersService.GetSpeakers();
        }

        // GET api/speakers/5
        [HttpGet("{id}")]
        public Models.Speaker Get(int id)
        {
            return _speakersService.GetSpeaker(id);
        }
    }
}
