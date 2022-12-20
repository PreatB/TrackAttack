using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace TrackAttack
{
    internal class Initializers
    {
        public static void initialize() {

            createPaths();
            databaseCreation();
        
        
        }




        public static void databaseCreation() {

            SQLiteConnection sqlConn;

            // Create a new database connection and new db if not exists
            sqlConn = new SQLiteConnection("Data Source=VideoDB.db;");
            sqlConn.Open();


            //Video Table
            string sqlText = "CREATE TABLE IF NOT EXISTS Videos(videoId INTEGER PRIMARY KEY AUTOINCREMENT, videoName TEXT, videoTime TEXT, videoLength INT, videoPath TEXT, trackId INT, trackTemp FLOAT, sessionId INT, analysed TEXT);";
            createTable(sqlText, sqlConn);

            //Tracks Table
            sqlText = "CREATE TABLE IF NOT EXISTS Tracks(trackId INTEGER PRIMARY KEY AUTOINCREMENT, trackName TEXT, trackLength TEXT, trackType TEXT, imagePath TEXT);";
            createTable(sqlText, sqlConn);

            //Session Table
            sqlText = "CREATE TABLE IF NOT EXISTS Sessions(sessionId INTEGER PRIMARY KEY AUTOINCREMENT, sessionName TEXT, trackId INT, driverIndex TEXT ,filePath TEXT, trackTemp FLOAT);";
            createTable(sqlText, sqlConn);


            sqlConn.Close();

        }


        public static void createTable(string sqlString, SQLiteConnection sqlConn) {

            SQLiteCommand sqlCmd;
            sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = sqlString;
            sqlCmd.ExecuteNonQuery();

        }

        public static void createPaths() {
            Directory.CreateDirectory("VideoData/Videos");
            Directory.CreateDirectory("VideoData/LapData");
            Directory.CreateDirectory("VideoData/Events");


        }

        
    }
}
