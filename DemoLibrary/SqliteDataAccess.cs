using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqliteDataAccess : DataAccess
    {

        public override string LoadConnectionString(string name) 
        {
            //let the original method do its job
            string returnString = base.LoadConnectionString(name);
            var sb = new StringBuilder();
            sb.AppendLine(returnString);
            sb.AppendLine("new string from SqliteDataAccess");
            Console.WriteLine($"SQLLITE: {sb.ToString()}");
            return sb.ToString();
        }

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading SQLite Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }
    }
}
