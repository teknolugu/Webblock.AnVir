using System.Data;
using System.Data.SQLite;

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