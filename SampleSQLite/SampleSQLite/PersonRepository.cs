using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSQLite
{
    public class PersonRepository
    {
        SQLiteConnection dbConn;

        public PersonRepository()
        {
            dbConn = Xamarin.Forms.DependencyService.Get<ISqlite>().GetConnection();
            dbConn.CreateTable<Person>();
        }

        public int InsertPerson(Person param)
        {
            int result = 0;

            var person = dbConn.Query<Person>("Select * from People where Name=?", param.Name);
            //var person = dbConn.Table<Person>().Where(x => x.Name == param.Name);

            if (person.Count != 0)
            {
                result = -1;
            }
            else
            {
                result = dbConn.Insert(param);
            }

            return result;
        }

        public List<Person> GetAllPerson()
        {
            return dbConn.Table<Person>().ToList();
        }

        public int DeletePerson (Person param)
        {
            return dbConn.Delete(param);
        }
    }
}
