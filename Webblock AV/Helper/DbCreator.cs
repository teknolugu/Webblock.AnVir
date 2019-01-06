using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Webblock_AV.Helper
{
    public static class DbCreator
    {
        public static SQLiteConnection con;
        public static SQLiteCommand cmd;

        public static void CreateDb()
        {
            //create db
            SQLiteConnection.CreateFile(@"Database\virData.db");
            con = new SQLiteConnection(@"DataSource=Database\quarantined.db;Version=3;");
            if (con.State == ConnectionState.Closed) con.Open();
            con.SetPassword("ac43724f16e9241d990427ab7c8f4228");
            cmd = new SQLiteCommand("CREATE TABLE file(ID INTEGER PRIMARY KEY AUTOINCREMENT, fileName TEXT, filePath TEXT, virusName VARCHAR(100), Status VARCHAR(20))", con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
        }
    }
}
