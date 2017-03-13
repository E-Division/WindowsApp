using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Divison.Classes
{
    class Category
    {
        //VARIABLES
        public int pageID;
        public int categoryID;
        public int categoryParentID;
        public string categoryName;
        public string categoryDescription;
        public byte[] categoryImage;

        //Constructor
        public Category(int pageID, int categoryID, int categoryParentID, string categoryName, string categoryDescription, byte[] categoryImage)
        {
            this.pageID = pageID;
            this.categoryID = categoryID;
            this.categoryParentID = categoryParentID;
            this.categoryName = categoryName;
            this.categoryDescription = categoryDescription;
        }

    }
}
