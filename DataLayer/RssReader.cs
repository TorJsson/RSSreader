using System;
using System.Collections.Generic;
using System.Xml;
using System.ServiceModel.Syndication;

namespace DataLayer
{
    public class RssReader : IFeedsRepository<Feeds>
    {

        public RssReader()
        {

        }

        public Feeds GetFeeds(String url)
        {
            Feeds feeds = new Feeds();
            try
            {
                XmlReader xmlLasare = XmlReader.Create(url);
                SyndicationFeed feed = SyndicationFeed.Load(xmlLasare);
                xmlLasare.Close();
                return FeedFromSyndicationFeed(feed);
            }
            catch (NullReferenceException)
            {
                return feeds;
            }

        }

        private Feeds FeedFromSyndicationFeed(SyndicationFeed feed)

        {
            Feeds feeds = new Feeds();
            feeds.FeedTitle = feed.Title.Text;
            feeds.EpisodeList = EpisodeFromSyndicationFeedAllEpisodes(feed.Items);
            return feeds;
        }

        private List<Episodes> EpisodeFromSyndicationFeedAllEpisodes(IEnumerable<SyndicationItem> SyndicationItemList)
        {
            List<Episodes> output = new List<Episodes>();

            foreach (var item in SyndicationItemList)
            {
               output.Add(EpisodeFranSyndicationFeedEpisode(item));
            }

            return output;
        }

        private Episodes EpisodeFranSyndicationFeedEpisode(SyndicationItem syndicationItem)
        {
            Episodes output = new Episodes();
            output.EpisodeTitle = syndicationItem.Title.Text;
            output.EpisodeDescription = syndicationItem.Summary.Text;

            return output;
        }

    }
}
