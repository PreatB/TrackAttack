using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace TrackAttack
{
    public static class SessionPanel
    {



        public static List<SessionClass> loadSessionDB() {

            SQLiteConnection sqlConn;
            SQLiteDataReader rea;
            SQLiteCommand sqlCmd;

            sqlConn = new SQLiteConnection("Data Source=VideoDB.db;");
            sqlConn.Open();


            sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "SELECT * FROM Sessions";
            rea = sqlCmd.ExecuteReader();


            List<SessionClass> sessionList = new List<SessionClass>();

            while (rea.Read())
            {

                sessionList.Add(new SessionClass(rea.GetInt32(0), rea.GetInt32(1), rea.GetString(2), rea.GetFloat(3)));


            }

            sqlConn.Close();
            return sessionList;







        }



    }
}
