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

        public void Insert(Content content)
        {
            SQLiteConnection conn = new SQLiteConnection(connString);
            conn.Open();
            //string sql = "select * from test";
            string sql = "insert into content(Title,Text) values(@Title,@Text)";
            int i = conn.Execute(sql, content);
            //var s=conn.Query(sql).ToList();
            conn.Close();
        }

        public List<Content> Select()
        {
            SQLiteConnection conn = new SQLiteConnection(connString);
            conn.Open();
            string sql = "select * from Content";
            var list = conn.Query<Content>(sql).ToList();
            return list;
        }

        public Content SelectById(int id)
        {
            SQLiteConnection conn = new SQLiteConnection(connString);
            conn.Open();
            string sql = String.Format("select * from Content where id={0}",id);
            Content list = conn.Query<Content>(sql).SingleOrDefault();
            return list;
        }


    }
}
