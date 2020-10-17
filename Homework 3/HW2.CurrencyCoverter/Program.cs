using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CurrencyConverter
{
    /// <summary>
    /// Конвектор валюти, дані про курс бере з сайту НБУ
    /// </summary>
    class Program
    {
       
        static void Main(string[] args)
        {
            //З сайту банку отримуєм Json дані
            string url = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd(); //response - масив обєктів типу Json
            }
            List<CurrencyResponse> currencyResponses = JsonConvert.DeserializeObject<List<CurrencyResponse>>(response);

            double usd = currencyResponses[26].Rate, eur = currencyResponses[33].Rate;
            CurrConverter conv = new CurrConverter(usd, eur);
            conv.ToConverte();
        }
    }
}
