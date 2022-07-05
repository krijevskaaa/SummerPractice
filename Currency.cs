using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice.nbu
{
    /*NBU nbu1 = new NBU();
    ....
    ui.Add(NBU1.txt);*/
    public class Currency
    {
        public int r030 { get; set; }
        public string txt { get; set; }
        public double rate { get; set; }
        public string cc { get; set; }
        public string exchangedate { get; set; }
    }
}

/*s1 = "{\"r030\":36,\"txt\":\"Австралійський долар\",\"rate\":19.8363,\"cc\":\"AUD\",\"exchangedate\":\"04.07.2022\"}";
nbu1 = JsonConvert.DeserializeObject<NBU>(s1);
//getCurr1.Items.Add(js);
//NBU nbu1 = new NBU();

getCurr1.Items.Add(nbu1.txt);
*/