using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SummerPractice;
using System.Web.Script.Serialization;
using System.Security.Policy;
using DevExpress.Utils.About;
using System.Text.Json;
using System.Net;
using System.IO;
using SummerPractice.nbu;

namespace SummerPractice
{
    public partial class ConvertForm : Form
    {
        private const int grn = 1;
        private Func<List<Currency>> nbu;

        public ConvertForm()
        {
            InitializeComponent();
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            getCurr1.Items.Add("Гривня");
            getCurr2.Items.Add("Гривня");
            List<Currency> Nbu = NbuAPI.GetCurrencyToday();
            foreach (var item in Nbu)
            {
                getCurr1.Items.Add(item.txt);
                getCurr2.Items.Add(item.txt);
            }
        }
        private void getCurr1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (getCurr1.SelectedIndex == 0)
            {
                kurs1.Text = grn.ToString();
            } else
            {
                nbu = NbuAPI.GetCurrencyToday;
                kurs1.Text = NbuAPI.GetCurrencyToday()[getCurr1.SelectedIndex - 1].rate.ToString();
            }
        }

        private void getCurr2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (getCurr1.SelectedIndex == 0)
            {
                kurs1.Text = grn.ToString();
            }
            else
            {
                nbu = NbuAPI.GetCurrencyToday;
                kurs2.Text = NbuAPI.GetCurrencyToday()[getCurr2.SelectedIndex - 1].rate.ToString();
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            this.Close();
            var f1 = new MainForm();
            f1.Show();
        }

        private void GetResult_Click(object sender, EventArgs e)
        {
            double k1 ;
            double k2 ;
            double price;
            l_result.Text = "";
            try
            {
                double.TryParse(kurs1.Text, out k1);
                double.TryParse(kurs2.Text, out k2);
                double.TryParse(tb_sum.Text, out price);
                double res = k1 / k2 * price;
                l_result.Text = System.Convert.ToString(res);
            } catch
            {
                MessageBox.Show("error");
            }
        }

        private void tb_sum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ".") && (l_result.Text.IndexOf(".") == -1)))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
