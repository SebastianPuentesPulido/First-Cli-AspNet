using System;
using System.Net;
using Newtonsoft.Json;

namespace MyCli
{
    class Program
    {
        static void Main(string[] args)
        {
            string API_URL = "https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=100&page=1&sparkline=false";
            var Client = new WebClient();
              var json = Client.DownloadString(API_URL);
        dynamic posts = JsonConvert.DeserializeObject(json);

        foreach (var post in posts) {
            Console.WriteLine($"CryptoMoneda=> {post.id}; Precio_Currencial=> {post.current_price}; Simbolo=> {post.symbol}");
        }

        }
    }
}
