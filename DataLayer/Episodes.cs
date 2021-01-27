using System;

namespace DataLayer
{
    public class Episodes : Feeds
    {
        public String EpisodeTitle { get; set; }
        public String EpisodeDescription { get; set; }
        public Episodes() { }
        public override string GetTitle()
        {
            return EpisodeTitle;
        }

        public override string ToString()
        {
            return EpisodeTitle;
        }
    }
}
