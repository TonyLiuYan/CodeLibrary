using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CodeLibraryDB
{
    public class DB
    {
        private static readonly string connString = @"Data Source=E:\VisualStudioCode\CodeLibrary\CodeLibrary\CodeLibrary\App_Data\CodeLibrary.db;";

        public void Open()
        {

            SQLiteConnection conn = new SQLiteConnection(connString);
            conn.Open();

            string sql = "select * from test";

            var s=conn.Query(sql).ToList();

            conn.Close();
        }
    }
}
