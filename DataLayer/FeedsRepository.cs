using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class FeedsRepository : IRepository<Feeds>
    {
        DataManagerXML xmlManager;
        List<Feeds> feedsList;

        public FeedsRepository()
        {
            feedsList = new List<Feeds>();
            xmlManager = new DataManagerXML();
            feedsList = GetAll();
        }

        public void Create(Feeds entity)
        {
            feedsList.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            feedsList.RemoveAt(index);
            SaveChanges();
        }

        public void Update(int index, Feeds entity)
        {

            feedsList[index] = entity;
            SaveChanges();
        }

        public void SaveChanges()
        {
            xmlManager.Serialize(feedsList);
        }

        public List<Feeds> GetAll()
        {
            List<Feeds> feedsListToBeReturned = new List<Feeds>();
            try
            {
                feedsListToBeReturned = xmlManager.Deserialize();
            }
            catch (Exception)
            {
            }

            return feedsListToBeReturned;

        }

       
    }

}

