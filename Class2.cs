/*using System;
using System.Linq;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Xml.Linq;
using Windows.Web.Syndication;
using SyndicationCategory = System.ServiceModel.Syndication.SyndicationCategory;
using SyndicationContent = System.ServiceModel.Syndication.SyndicationContent;
using SyndicationItem = System.ServiceModel.Syndication.SyndicationItem;

namespace SyndicationCreator
{
    public class Formula1Feed : IFormula1Feed
    {
        public SyndicationFeedFormatter CreateFeed()
        {
            DateTime fromDate = DateTime.Today - TimeSpan.FromDays(365);
            DateTime toDate = DateTime.Today;
            string from = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters["from"];
            string to = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters["to"];

            if (from != null && to != null)
            {
                try
                {
                    fromDate = DateTime.Parse(from);
                    toDate = DateTime.Parse(to);
                }
                catch (FormatException)
                {
                    // Сохранение дат по умолчанию
                }
            }

            // Создание нового синдицируемого канала (SyndicationFeed)
            var feed = new System.ServiceModel.Syndication.SyndicationFeed();
            feed.Generator = "";
            feed.Generator = "C# RSS Sample";
            feed.Language = "ua-ua";
            feed.LastUpdatedTime = new DateTimeOffset(DateTime.Now);
            feed.Title = System.ServiceModel.Syndication.SyndicationContent.CreatePlaintextContent("Результаты Формулы-1");
            feed.Categories.Add(new SyndicationCategory("Формула-1"));
            feed.Authors.Add(new System.ServiceModel.Syndication.SyndicationPerson("alexerohinzzz@gmail.com",
                  "Christian Nagel", "http://www.professorweb.ru"));
            feed.Description = System.ServiceModel.Syndication.SyndicationContent.CreatePlaintextContent(
                  "Чемпионы Формулы-1");


            using (var data = new Formula1Entities())
            {
                var races = (from racer in data.Racers
                             from raceResult in racer.RaceResults
                             where raceResult.Race.Date > fromDate &&
                                raceResult.Race.Date < toDate &&
                                raceResult.Position == 1
                             orderby raceResult.Race.Date
                             select new
                             {
                                 Country = raceResult.Race.Circuit.Country,
                                 Date = raceResult.Race.Date,
                                 Winner = racer.Firstname + " " + racer.Lastname
                             }).ToArray();


                feed.Items = races.Select(race =>
                {
                    return new SyndicationItem
                    {
                        Title = SyndicationContent.CreatePlaintextContent(
                            String.Format("G.P. {0}", race.Country)),
                        Content = SyndicationContent.CreateXhtmlContent(
                            new XElement("p",
                                new XElement("h3", String.Format("{0}, {1}",
                                    race.Country, race.Date.ToShortDateString())),
                                new XElement("b", String.Format("Winner: {0}", race.Winner))).ToString())
                    };
                });



                // Возврат ATOM или RSS в зависимости от строки запроса
                // rss -> http://localhost:8732/Design_Time_Addresses/SyndicationService/Feed1/
                // atom -> http://localhost:8732/Design_Time_Addresses/SyndicationService/Feed1/?format=atom
                string query = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters["format"];
                SyndicationFeedFormatter formatter = null;
                if (query == "atom")
                {
                    formatter = new Atom10FeedFormatter(feed);
                }
                else
                {
                    formatter = new Rss20FeedFormatter(feed);
                }


                return formatter;
            }
        }
    }
}*/