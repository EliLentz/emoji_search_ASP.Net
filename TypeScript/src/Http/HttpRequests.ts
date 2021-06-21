import axios from 'axios';
import { Item } from '../Components/Emoji_List';

/**
 * Get async response from server
 */
export async function GetEmojis() : Promise<Item[]>{

  const SERVER_PATH = "http://127.0.0.1:26694/Emoji";

  return await axios.get(SERVER_PATH).then((resp) => {
    return resp.data;
  });
}