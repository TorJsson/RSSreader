using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class Feeds
    {
        public String FeedTitle { get; set; }
        public Categories FeedCategories { get; set; }
        public String FeedUrl { get; set; }
        public String FeedUpdateIntervall { get; set; }
        public List<Episodes> EpisodeList { get; set; }


        public virtual string GetTitle()
        {
            return FeedTitle;
        }

        public Feeds() 
        {
        }
    }
}












