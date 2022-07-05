/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SummerPractice
{
    class Class1: Form2
    {
        public string s1 = "";
        public List<NBU> nbu1;
        HttpClient httpClient = new HttpClient();
        static async Task Main(string[] arsgs)
        {
            Class1 class1 = new Class1();
            await class1.GetNBUItems();
        }
        private async Task GetNBUItems()
        {
            s1 = await httpClient.GetStringAsync("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchangenew?json");
            nbu1 = JsonConvert.DeserializeObject<List<NBU>>(s1);
            foreach (var item in nbu1)
            {
                
            }
        }




    }
}
*/