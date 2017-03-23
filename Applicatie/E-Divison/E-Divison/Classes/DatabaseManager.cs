﻿using System;
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

        public void CreateTables()
        {
            //var tableQuery = "SELECT COUNT(*) FROM tbl_Page;";
            //bool tableExists = con.ExecuteScalar<int>(tableQuery) == 1;
            con.CreateTable<Page>();
        }
        public SQLiteConnection GetCon()
        {
            return con;
        }
    }
}
