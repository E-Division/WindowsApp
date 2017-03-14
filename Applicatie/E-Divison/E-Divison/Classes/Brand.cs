using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Divison.Classes
{
    class Brand
    {
        public int brandID;
        public int brandParentID;
        public string brandName;
        public byte[] brandImage;

        public Brand(int brandID, int brandParentID, string brandName, byte[] brandImage)
        {
            this.brandID = brandID;
            this.brandParentID = brandParentID;
            this.brandName = brandName;
            this.brandImage = brandImage;
        }
    }
}
