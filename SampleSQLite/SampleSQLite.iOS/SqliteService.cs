using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;
using SampleSQLite.iOS;

[assembly:Xamarin.Forms.Dependency(typeof(SqliteService))]
namespace SampleSQLite.iOS
{
    public class SqliteService : ISqlite
    {
        public SQLiteConnection GetConnection()
        {
            string dbName = "person.db3";
            string FolderPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string dbPath = Path.Combine(FolderPath, "..", "Library", "Databases",dbName);

            if (!File.Exists(dbPath)) File.Create(dbPath);

            var con = new SQLiteConnection(dbPath);

            return con;
        }
    }
}
