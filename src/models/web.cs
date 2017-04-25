using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class web
    {
        public string get(string address)
        {
            WebClient client = new WebClient();

            string reply;
            try
            {
                reply = client.DownloadString(address);
            }
            catch(Exception)
            {
                reply = "";
            }

            return reply;
        }

        public string post(string address)
        {
            return "";
            /*
            HttpClient client = new HttpClient();

            var pairs = new List<KeyValuePair<string, string>>{
        new KeyValuePair<string, string>("username", ""),
        new KeyValuePair<string, string>("password", "")
    };

            string content = new FormUrlEncodedContent(pairs);

            var response = client.PostAsync("youruri", content).Result;

            if (response.IsSuccessStatusCode)
            {
            }

            return response.;
            */
        }
    }
}
