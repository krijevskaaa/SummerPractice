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
using SummerPractice.nbu;
using Google.Type;

namespace SummerPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // _ = MessageBox.Show("ejnvedoujbvo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f2 = new ConvertForm();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var f3 = new NewsForm();
            f3.Show();
            this.Hide();
        }

        public List<Currency> nbu;
        //private string postParams;

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Date date = monthCalendar1.SelectionRange.Start.Date.ToString("yyyyMMdd");
            this.label1.Text = monthCalendar1.SelectionRange.Start.Date.ToString("yyyyMMdd");
            nbu = NbuAPI.GetCurrencyDate(monthCalendar1.SelectionRange.Start.Date);
            /*using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchangenew?json");
                var result = await client.PostAsync("/api/foo", new StringContent(monthCalendar1.SelectionRange.Start.Date.ToShortDateString()));
                string resultContent = await result.Content.ReadAsStringAsync();
                this.label1.Text = resultContent;
            }*/
            // root is a Panel that is defined elsewhere.

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
// 840 doolar usa , 978 euro, 643 rub, 756 franc, 826 funt