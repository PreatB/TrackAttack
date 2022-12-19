using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackAttack
{
    public class SessionClass
    {

        public int sessionId;
        public int trackId;
        public string filePath;
        public float trackTemp;



        public SessionClass(int sessionId, int trackId, string filePath, float trackTemp)
        {
            this.trackId = trackId;
            this.sessionId = sessionId;
            this.filePath = filePath;
            this.trackTemp = trackTemp;



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


        public TrackClass(int videoId, string videoName, string videoTime, int videoLength, string videoPath, int trackId, float trackTemp, int sessionId, string analysed)
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
        public int trackLength;
        public string tracktype;
        public string imagePath;

        
        public TrackClass() { 
        
        
        
        
        
        }
    
    
    
    
    
    
    }



}
