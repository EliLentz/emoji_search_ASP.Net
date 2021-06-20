using Microsoft.AspNetCore.Mvc;

namespace emoji_search_back.Controller
{
    /// <summary>
    /// Controller, that allows to set requests to this server
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class EmojiController : ControllerBase
    {
        // GET: Emoji
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Deserealized json of emojis</returns>
        [HttpGet]
        public Models.Emoji[] GetEmojis()
        {
            return JSONReader.GetEmojis();
        }
    }   
}
