using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace emoji_search_back.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class EmojiController : ControllerBase
    {
        // GET: Emoji
        [HttpGet]
        public Models.Emoji[] GetEmojis()
        {
            return JSONReader.GetEmojis();
        }
    }
}
