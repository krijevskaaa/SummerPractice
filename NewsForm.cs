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
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Xml.Linq;
using Windows.Web.Syndication;
using SyndicationCategory = System.ServiceModel.Syndication.SyndicationCategory;
using SyndicationContent = System.ServiceModel.Syndication.SyndicationContent;
using SyndicationFeed = System.ServiceModel.Syndication.SyndicationFeed;
using SyndicationItem = System.ServiceModel.Syndication.SyndicationItem;
using SyndicationPerson = System.ServiceModel.Syndication.SyndicationPerson;

namespace SummerPractice
{
    public partial class NewsForm : Form
    {
        public NewsForm()
        {
            InitializeComponent();
        }

        private void NewsForm_Load(object sender, EventArgs e)
        {            
            IEnumerable<FeedItem> f = RssParser.GetLatestFivePosts();
            foreach (var item in f)
            {
                listView1.Items.Add (item.Title + "\r" + item.Link + "\r\r\r");
            };
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
            var f1 = new MainForm();
            f1.Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


