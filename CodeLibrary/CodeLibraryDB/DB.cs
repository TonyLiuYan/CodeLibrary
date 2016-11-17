using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeLibraryDB.Model;
using Dapper;

namespace CodeLibraryDB
{
    public class DB
    {
        private static readonly string connString = @"Data Source=E:\VisualStudioCode\CodeLibrary\CodeLibrary\CodeLibrary\App_Data\CodeLibrary.db;";

        public void Insert(string content)
        {

            SQLiteConnection conn = new SQLiteConnection(connString);
            conn.Open();

            //string sql = "select * from test";
            string sql = "insert into content(Text) values(@Text)";

            Content c=new Content();
            c.Text = content;
           
            int i = conn.Execute(sql, c);

            //var s=conn.Query(sql).ToList();

            conn.Close();
        }


    }
}
