using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace TrackAttack
{
    public class SessionClass
    {

        public int sessionId;
        public int trackId;
        public string filePath;
        public float trackTemp;
        public string sessionName;
        public string driverIndex;
        


        public SessionClass(int sessionId, string sessionName, int trackId, string driverIndex, string filePath, float trackTemp)
        {
            this.trackId = trackId;
            this.sessionName = sessionName;
            this.sessionId = sessionId;
            this.filePath = filePath;
            this.trackTemp = trackTemp;
            this.driverIndex = driverIndex;


        }




    }

    public class VideoClass
    {
        public int videoId;
        public string videoName;
        public string videoTime;
        public string videoPath;
        public int trackId;
        public float trackTemp;
        public int sessionId;
        public string analysed;
        public int videoLength;


        public VideoClass(int videoId, string videoName, string videoTime, int videoLength, string videoPath, int trackId, float trackTemp, int sessionId, string analysed)
        {

            this.videoName = videoName;
            this.videoTime = videoTime;
            this.trackTemp = trackTemp;
            this.videoId = videoId;
            this.videoPath = videoPath;
            this.trackId = trackId;
            this.sessionId = sessionId;
            this.analysed = analysed;
            this.videoLength = videoLength;





        }





    }

    public class TrackClass {
        //(trackId INTEGER PRIMARY KEY AUTOINCREMENT, trackName TEXT, trackLength TEXT, trackType INT, imagePath TEXT)
        
        public int trackId;
        public string trackName;
        public string trackLength;
        public string trackType;
        public string imagePath;
        public static IDictionary<int, string> trackDict = new Dictionary<int, string>();
        public static List<TrackClass> trackList = new List<TrackClass>();
        public static List<string> trackNameList = new List<string>();

        
        
        public TrackClass(int trackId, string trackName, string trackLength, string trackType, string imagePath) {
            this.trackId = trackId;
            this.trackName = trackName;
            this.trackLength = trackLength;
            this.trackType = trackType;
            this.imagePath = imagePath;

            if (!trackDict.ContainsKey(trackId)) {
                trackDict.Add(trackId, trackName);
            }

        
        
        
        
        }

        public static List<string> loadTrackList()
        {

            SQLiteConnection sqlConn;
            SQLiteDataReader rea;
            SQLiteCommand sqlCmd;
            trackNameList.Clear();
            trackList.Clear();
            trackDict.Clear();


            sqlConn = new SQLiteConnection("Data Source=VideoDB.db;");
            sqlConn.Open();


            sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "SELECT * FROM Tracks";
            rea = sqlCmd.ExecuteReader();


            

            while (rea.Read())
            {
                Console.WriteLine(rea.GetInt32(0));
                Console.WriteLine(rea.GetString(1));
                Console.WriteLine(rea.GetString(2));
                Console.WriteLine(rea.GetString(3));
                Console.WriteLine(rea.GetString(4));
                TrackClass tempObj = new TrackClass(rea.GetInt32(0), rea.GetString(1), rea.GetString(2), rea.GetString(3), rea.GetString(4));
                trackList.Add(tempObj);
                trackNameList.Add(tempObj.trackName);

            }

            sqlConn.Close();
            return trackNameList;



        }


        public static int findTrackId(string trackName) {

            foreach (TrackClass track in trackList) {

                if (track.trackName == trackName) {
                    return track.trackId;
                }
            
            
            }
            return 0;
        
        
        
        
        
        }


    }



}
