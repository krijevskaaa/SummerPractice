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
using SummerPractice.Nbu;

namespace SummerPractice
{
    public partial class ConvertForm : Form
    {
        private const double grn = 1;

        List<Currency> currencies;
        public ConvertForm()
        {
            InitializeComponent();
        }


        private void ConvertForm_Load(object sender, EventArgs e)
        {
            cb_getCurr1.Items.Add("Гривня");
            cb_getCurr2.Items.Add("Гривня");
            currencies = NbuAPI.GetCurrencyToday();
            foreach (var item in currencies)
            {
                cb_getCurr1.Items.Add(item.txt);
                cb_getCurr2.Items.Add(item.txt);
            }
        }
        private void cb_getCurr1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_getCurr1.SelectedIndex == 0)
            {
                kurs1.Text = grn.ToString();
            }
            else
            { 
                kurs1.Text = currencies[cb_getCurr1.SelectedIndex - 1].rate.ToString();
            }
        }

        private void cb_getCurr2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_getCurr2.SelectedIndex == 0)
            {
                kurs2.Text = grn.ToString();
            }
            else
            {
                kurs2.Text = currencies[cb_getCurr2.SelectedIndex - 1].rate.ToString();
            }
        }


        private void b_switch_Click(object sender, EventArgs e)
        {
            var conteiner = cb_getCurr1.SelectedItem.ToString();
            cb_getCurr1.Text = cb_getCurr2.Text;
            cb_getCurr2.Text = conteiner;
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            this.Close();
            var f1 = new MainForm();
            f1.Show();
        }

        private void GetResult_Click(object sender, EventArgs e)
        {
            double k1;
            double k2;
            double price;
            l_result.Text = "";
            try
            {
                double.TryParse(kurs1.Text, out k1);
                double.TryParse(kurs2.Text, out k2);
                double.TryParse(tb_sum.Text, out price);
                double res = k1 / k2 * price;
                string kod;
                if (k2 == 1) { kod = "grn"; } else { kod = currencies[cb_getCurr2.SelectedIndex - 1].cc; }
                l_result.Text = Convert.ToString(Math.Round(res,2)) + " " + kod;
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void tb_sum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ".") && (l_result.Text.IndexOf(".") == -1)))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
