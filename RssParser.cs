using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SummerPractice
{
    /*class RssParser
    {
        public async void ParseRSS()
        {
            string feed = null;

            using (var client = new HttpClient())
            {
                try
                {
                    feed = await client.GetStringAsync("https://visualstudiomagazine.com/rss-feeds/news.aspx");
                }
                catch { }
            }

            if (feed != null)
            {
                var parser = new RssParser();
                var rss = parser.Parse(feed);

                foreach (var element in rss)
                {
                    Console.WriteLine($"Title: {element.Title}");
                    Console.WriteLine($"Summary: {element.Summary}");
                }
            }
        }
        //For non-UWP use the Syndication from the namespace System.ServiceModel.Syndication as others suggested.
        
public static IEnumerable<FeedItem> GetLatestFivePosts()
    {
        var reader = XmlReader.Create("https://sibeeshpassion.com/feed/");
        var feed = SyndicationFeed.Load(reader);
        reader.Close();
        return (from itm in feed.Items
                select new FeedItem
                {
                    Title = itm.Title.Text,
                    Link = itm.Id
                }).ToList().Take(5);
    }

    public class FeedItem
    {
        public string Title
        {
            get;
            set;
        }
        public string Link
        {
            get;
            set;
        }
    }
    }*/
    class RssParser: NewsForm
    {

        public static List<FeedItem> GetLatestFivePosts()
        {
        var reader = XmlReader.Create("https://www.ukrbanks.info/news/rss/");
        var feed = SyndicationFeed.Load(reader);
        reader.Close();
        IEnumerable<FeedItem> f =  (from itm in feed.Items
            select new FeedItem
            {
                Title = itm.Title.Text,
                Link = itm.Id
            }).ToList().Take(5);
        return f.ToList();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(600, 518);
            this.Name = "RssParser";
            this.ResumeLayout(false);

        }
    }
    public class FeedItem
    {
        public string Title
        {
            get;
            set;
        }
        public string Link
        {
            get;
            set;
        }
    }
}
