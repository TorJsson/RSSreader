using DataLayer;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccessLayer
{
    internal class DataManagerXML
    {
    
        public void Serialize(List<Feeds> feedsList)
        {

            XmlSerializer xmlSerializer = new XmlSerializer(feedsList.GetType());
            using (FileStream outFile = new FileStream("Feeds.xml", FileMode.Create,
                FileAccess.Write))
            {
               xmlSerializer.Serialize(outFile, feedsList);
            }

        }

        public List<Feeds> Deserialize()
        {

            List<Feeds> feedsListToBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Feeds>));
            using (FileStream inFile = new FileStream("Feeds.xml", FileMode.Open,
                FileAccess.Read))
            {
                feedsListToBeReturned = (List<Feeds>)xmlSerializer.Deserialize(inFile);
            }
            return feedsListToBeReturned;

        }
    }
}
