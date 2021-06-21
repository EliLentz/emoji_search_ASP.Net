using Newtonsoft.Json;
using emoji_search_back.Models;
using System.IO;

namespace emoji_search_back
{
    /// <summary>
    /// Read the Json file with emojis and deserialize it to array type of Emoji
    /// </summary>
    public class JSONReader
    {
        #region Data Members
        /// <summary>
        /// Json, that deserialized to array type of Emoji
        /// </summary>
        private static Emoji[] emojis;
        /// <summary>
        /// path to emoji json file
        /// </summary>
        private const string JSON_PATH = @"JSON/emojiList.json";
        #endregion

        private static void LoadJson()
        {
            using (StreamReader r = new StreamReader(JSON_PATH))
            {
                string json = r.ReadToEnd();
                emojis = JsonConvert.DeserializeObject<Emoji[]>(json);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>array type of Emoji from Json file</returns>
        public static Emoji[] GetEmojis()
        {
            LoadJson();
            return emojis;
        }
    }
}
