using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice.Nbu
{
    public class Currency
    {
        public int r030 { get; set; }
        public string txt { get; set; }
        public double rate { get; set; }
        public string cc { get; set; }
        public string exchangedate { get; set; }

        public string ShortInfo()
        {
            return txt + " " + cc + " = " + rate.ToString();
        }
    }
}
