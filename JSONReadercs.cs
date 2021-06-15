using Newtonsoft.Json;
using emoji_search_back.Models;
using System.IO;

namespace emoji_search_back
{
    public class JSONReader
    {
        private static Emoji[] emojis;
        private const string JSON_PATH = @"JSON/emojiList.json";

        private static void LoadJson()
        {
            using (StreamReader r = new StreamReader(JSON_PATH))
            {
                string json = r.ReadToEnd();
                emojis = JsonConvert.DeserializeObject<Emoji[]>(json);
            }
        }

        public static Emoji[] GetEmojis()
        {
            LoadJson();
            return emojis;
        }
    }
}
