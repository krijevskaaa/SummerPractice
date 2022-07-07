using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice.Nbu
{
    class NbuAPI
    {
        //public static List<Currency> nbu1;
        public static List<Currency> GetCurrencyToday()
        {
            WebRequest request = WebRequest.Create("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchangenew?json");
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string s1 = reader.ReadToEnd();
            List<Currency> nbu1 = JsonConvert.DeserializeObject<List<Currency>>(s1);
            return nbu1;
        }
        public static List<Currency> GetCurrencyDate(string date)
        {
            WebRequest request = WebRequest.Create("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchangenew?json&&date=" + date);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string s1 = reader.ReadToEnd();
            List<Currency> nbu1 = JsonConvert.DeserializeObject<List<Currency>>(s1);
            return nbu1;
        }
    }
}
