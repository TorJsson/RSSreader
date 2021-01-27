using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataLayer;


namespace MiddleLayer
{


    public class FeedsMethods
    {

        private static List<Feeds> feeds = new List<Feeds>();
        private IRepository<Feeds> feedsRepository;


        public FeedsMethods()
        {
            feedsRepository = new FeedsRepository();

        }

        

        public List<Feeds> RetrieveAllFeeds()
        {
            return feedsRepository.GetAll();

        }

        public void DeleteFeed(int index)
        {
            feedsRepository.Delete(index);

        }

        public void UpdateFeeden(int index, Feeds entity)
        {
            feedsRepository.Update(index, entity);

        }

        public void FeedController(String addedName, String loadedUrl, String updateFrequency, Categories kategori)
        {
            try
            {
               Feeds feed = new RssReader().GetFeeds(loadedUrl);
               
                feed.FeedUrl = loadedUrl;
                feed.FeedCategories = kategori;
                feed.FeedTitle = addedName;
                feed.FeedUpdateIntervall = updateFrequency;
               

                feedsRepository.Create(feed);
           
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}










