using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using SummerPractice.Nbu;
using Google.Type;

namespace SummerPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void b_to_convert_Click(object sender, EventArgs e)
        {
            var f2 = new ConvertForm();
            f2.Show();
            this.Hide();
        }

        private void b_to_news_Click_1(object sender, EventArgs e)
        {
            var f3 = new NewsForm();
            f3.Show();
            this.Hide();
        }

        //public readonly string[] popularCurrenciesCc = { "USD", "EUR" };

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date = monthCalendar1.SelectionRange.Start.ToString();
            this.l_data.Text = monthCalendar1.SelectionRange.Start.Date.ToString("dd.MM.yyyy") + "\r"
                + "Курс валют до гривні на обрану дату:" + "\r\r";
            List<Currency> nbu = NbuAPI.GetCurrencyDate(monthCalendar1.SelectionRange.Start.Date.ToString("yyyyMMdd"));
            foreach(var item in nbu)
            {
                if (item.cc == "USD") { l_data.Text += item.ShortInfo() + "\r"; }
                else if (item.cc == "EUR") { l_data.Text += item.ShortInfo() + "\r"; }
                else if (item.cc == "CHF") { l_data.Text += item.ShortInfo() + "\r"; }
                else if (item.cc == "GBP") { l_data.Text += item.ShortInfo() + "\r"; }
            }
        }

        private void l_data_Click(object sender, EventArgs e)
        {

        }
    }
}
// 840 doolar usa , 978 euro, 643 rub, 756 franc, 826 funt