using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Divison.Classes
{
    public class Page
    {
        public int pageID;
        public string pageType;
        public string pageName;
        public string pageDescription;
        public string pageTextHeader;
        public string pageTextCenter;
        public string pageTextFooter;
        public byte[] pageImage;

        public Page(int pageID, string pageType, string pageName, string pageDescription, string pageTextHeader, string pageTextCenter, string pageTextFooter, byte[] pageImage)
        {
            this.pageID = pageID;
            this.pageType = pageType;
            this.pageName = pageName;
            this.pageDescription = pageDescription;
            this.pageTextHeader = pageTextHeader;
            this.pageTextCenter = pageTextCenter;
            this.pageTextFooter = pageTextFooter;
            this.pageImage = pageImage;
        }

        public void CreateTable(SQLite.Net.SQLiteConnection con)
        {
            con.CreateTable<Page>();
            con.Insert(new Page(1, "Activity", "Home", "E-Division", "", "", "", new byte[new byte[], ]));
            //con.Insert(new Page()
            //{
            //    Name = textBox.Text,
            //    Age = textBox1.Text
            //});
        }
    }
}
