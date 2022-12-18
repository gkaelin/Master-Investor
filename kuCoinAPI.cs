using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text.Json.Nodes;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Net.Http.Json;

namespace Master_Investor
{
    internal class kuCoinAPI
    {
        //Attributs de la classe

        public kuCoinAPI() 
        {
            
        }


        public string getAllTicker()
        {
            string url = "https://api.kucoin.com/api/v1/market/allTickers";

            HttpClient client = new HttpClient();
            var res = client.GetStringAsync(url);
            var Answer = res.Result;

            return Answer;
        }
    }
}
