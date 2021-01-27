using System.Collections.Generic;

namespace MiddleLayer
{
    public class CategoryStorage
    {
        public static void SaveCategories(List<string> CategoryList)
        {
            CategorySerializer.SaveCategories(CategoryList);
        }

        public static List<string> GetCategories()
        {
            return CategorySerializer.GetCategory();
        }
    }
}
