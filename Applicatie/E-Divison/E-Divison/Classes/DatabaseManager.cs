using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Divison.Classes
{
    class DatabaseManager
    {

        public DatabaseManager()
        {
            string path = Path.Combine(Windows.Storage.ApplicationData.
       Current.LocalFolder.Path, "db.sqlite");

            SQLite.Net.SQLiteConnection conn = new SQLite.Net.SQLiteConnection(new
               SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);

            conn.CreateTable<Customer>();
        }
    }
}
