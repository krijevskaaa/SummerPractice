using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Windows.UI.Xaml;

namespace SummerPractice
{
    public partial class NewsForm : Form
    {
        public NewsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.Close();
             var f1 = new MainForm();
             f1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        /*private void OnGetFeed(object sender, RoutedEventArgs e)
        {
            try
            {
                using (XmlReader reader = XmlReader.Create(textUrl.Text))
                {
                    var formatter = new Rss20FeedFormatter();
                    formatter.ReadFrom(reader);
                    this.DataContext = formatter.Feed;
                    this.feedContent.DataContext = formatter.Feed.Items;
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "Syndication Reader");
            }
        }*/
        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*private IFileReaderService Json
        {
            get
            {
                return IFileReaderService;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string js = "";
            JavaScriptSerializer js = new JavaScriptSerializer();
            Person[] persons = js.Deserialize<Person[]>(json);
        }*/
    }
    public class NBU1
    {
        public int Age {get;set;}
        public string Name {get;set;}
    }
}
