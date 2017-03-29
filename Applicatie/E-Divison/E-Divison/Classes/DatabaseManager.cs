using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
namespace E_Divison.Classes
{
    class DatabaseManager
    {
        private SQLite.Net.SQLiteConnection con;
        private string databaseName;
        private string path;
        public DatabaseManager()
        {
            Init();
        //    if (!CheckFileExists(path).Result)
        //    {
        //        CreateTables();
        //    }
        }
        private void Init()
        {
            databaseName = "db.sqlite";
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, databaseName);
            con = new SQLite.Net.SQLiteConnection(new
            SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
        }

        private void CreateTables()
        {
            //var tableQuery = "SELECT COUNT(*) FROM tbl_Page;";
            //bool tableExists = con.ExecuteScalar<int>(tableQuery) == 1;
            con.CreateTable<Page>();
            Page page = new Page();
            page.InsertPages(con);
            con.CreateTable<Category>();
            Category category = new Category();
            category.InsertCategories(con);
            con.CreateTable<Brand>();
            Brand brand = new Brand();
            brand.InsertBrands(con);
        }
        public SQLiteConnection GetCon()
        {
            return con;
        }

        private async Task<bool> CheckFileExists(string fileName)
        {
            try
            {
                var store = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return true;
            }
            catch
            {
            }
            return false;
        }
    }
}
