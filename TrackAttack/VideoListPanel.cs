using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TrackAttack
{
    

    public static class VideoListPanel
    {
        public static void initialise() { 
            
            



            /*load db json
             * 
             * load listbox
             * load table
             * 
             * 
             * 
             * 
            */
        
        
        
        
        }

        public static List<VideoClass> loadVideoList() {
            
            SQLiteConnection sqlConn;
            SQLiteDataReader rea;
            SQLiteCommand sqlCmd;
            
            sqlConn = new SQLiteConnection("Data Source=VideoDB.db;");
            sqlConn.Open();
            
            
            sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "SELECT * FROM Videos";
            rea = sqlCmd.ExecuteReader();
            

            List<VideoClass> videoList = new List<VideoClass>();
            
            while (rea.Read()) {

                videoList.Add(new VideoClass(rea.GetInt32(0), rea.GetString(1), rea.GetString(2), rea.GetInt32(3), rea.GetString(4), rea.GetInt32(5), rea.GetFloat(6), rea.GetInt32(7), rea.GetString(8)));

            
            }

            sqlConn.Close();
            return videoList;
            


        }








        }


    
}
