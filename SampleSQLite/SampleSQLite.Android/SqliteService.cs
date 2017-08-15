using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System.IO;
using SampleSQLite.Droid;

[assembly:Xamarin.Forms.Dependency(typeof(SqliteService))]
namespace SampleSQLite.Droid
{
    public class SqliteService : ISqlite
    {
        public SQLiteConnection GetConnection()
        {
            string dbName = "People.db3";
            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string dbPath = Path.Combine(folderPath, dbName);

            if (!File.Exists(dbPath)) File.Create(dbPath);

            var conn = new SQLiteConnection(dbPath);

            return conn;
        }
    }
}