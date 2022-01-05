using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CardDeckAPI.Models
{
    public class CardsDAL
    {
        public NewDeck GetNewDeck(string id)
        {
            string url = $"https://deckofcardsapi.com/api/deck/new/" + id;

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string JSON = rd.ReadToEnd();
            rd.Close();


            NewDeck p = JsonConvert.DeserializeObject<NewDeck>(JSON);

            return p;
        }
        public DrawCards GetCards(string id)
        {
            string url = "https://deckofcardsapi.com/api/deck/new/draw/?count=5" + id;

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string JSON = rd.ReadToEnd();
            rd.Close();


            DrawCards p = JsonConvert.DeserializeObject<DrawCards>(JSON);

            return p;
        }
       
       
    }
}
