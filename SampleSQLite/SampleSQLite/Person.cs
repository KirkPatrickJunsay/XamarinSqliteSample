using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSQLite
{
    [Table("People")]
    public class Person
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }

        [MaxLength(50),Unique]
        public string Name { get; set; }
    }
}
