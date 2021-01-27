using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace MiddleLayer
{
    public class CategorySerializer
    {
        public static void SaveCategories(List<string> CategoryList)
        {
            using (var writer = new StreamWriter("kategorier.xml"))
            {
                var serializer = new XmlSerializer(typeof(List<string>));
                serializer.Serialize(writer, CategoryList);
                writer.Flush();
            }
        }

        public static List<string> GetCategory()
        {
            if (File.Exists("kategorier.xml") == false)
            {
                return new List<string>();
            }

            using (var stream = File.OpenRead("kategorier.xml"))
            {
                var serializer = new XmlSerializer(typeof(List<string>));
                return serializer.Deserialize(stream) as List<string>;
            }
        }

    }

}
