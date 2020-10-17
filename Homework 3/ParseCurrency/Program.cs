using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ParseCurrency
{
    class Program
    {

        static void Main(string[] args)
        {
            string url = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            List<CurrencyResponse> currencyResponses = JsonConvert.DeserializeObject<List<CurrencyResponse>>(response);

            Console.WriteLine($"{currencyResponses[26].CC} {currencyResponses[26].Rate}");

        }
    }
}

