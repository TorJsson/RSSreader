using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   
    public class Categories
    {
        public string CategoryName { get; set; }

        public Categories(string kategoriNamn)
        {
            CategoryName = kategoriNamn;
        }

        public override string ToString()
        {
            return CategoryName;
        }
       
        public Categories() { 

        
        }

      
    }
}
