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

        public DatabaseManager()
        {
            string path = Path.Combine(Windows.Storage.ApplicationData.
       Current.LocalFolder.Path, "db.sqlite");

            con = new SQLite.Net.SQLiteConnection(new
            SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);

            
        }

        public SQLiteConnection getCon()
        {
            return con;
        }
    }
}
