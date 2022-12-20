using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.Data.SQLite;


namespace TrackAttack
{
    public partial class FormAddSession : Form
    {
        public FormAddSession()
        {
            InitializeComponent();
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            Form form = new FormAddTrack();
            form.Show();
            
            listBoxTrackSelect.DataSource = TrackClass.loadTrackList();



        }

        private void FormAddSession_Enter(object sender, EventArgs e)
        {

            listBoxTrackSelect.DataSource = TrackClass.loadTrackList();


            //load listboxes for tracks again
            //check if file has been selected by the file dialog. if so then refresh the driver
            //name textbox for the user to select





        }

        private void richTextLapEntry_TextChanged(object sender, EventArgs e)
        {
            //count new lines and add lap counter to the left side
            var lineCount = richTextLapEntry.Lines.Count();
            lblCounter.Text = "Lap " + lineCount.ToString();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.CheckFileExists = true;
            //openFileDialog1.Filter = ".csv";

        }

        private void radioFileUpload_CheckedChanged(object sender, EventArgs e)
        {
            richTextLapEntry.Hide();
            btnOpenFile.Show();
            lblFileName.Show();


        }

        private void radioManualEntry_CheckedChanged(object sender, EventArgs e)
        {
            richTextLapEntry.Show();
            btnOpenFile.Hide();
            lblFileName.Hide();
        }

        private void FormAddSession_Load(object sender, EventArgs e)
        {
            listBoxDriverSelect.Hide();
            radioFileUpload.Checked = true;
            listBoxTrackSelect.DataSource = TrackClass.loadTrackList();

        }

        private void btnSubmitSession_Click(object sender, EventArgs e)
        {
            if (radioFileUpload.Checked) {
                string result = addSessionToDb();
                File.Copy(openFileDialog1.FileName, result);

            }
            else { createCSV(); }


             
            
        }
        public void createCSV() {

            int maxSession=-1;

            foreach (SessionClass session in SessionPanel.loadSessionDB()) { 
            if(session.sessionId >= maxSession){
                maxSession = session.sessionId;

                }
            
            
            }

            maxSession++;


            string tempPath = "VideoData//LapData//" + maxSession.ToString() + ".csv";

            using (var writer = new StreamWriter(GenerateStreamFromString(tempPath) , Encoding.UTF8))
            {
                writer.WriteLine("Driver");
                

            foreach (string line in richTextLapEntry.Lines)
            {
                    writer.WriteLine(line);
                    
            }


            }

            //update db

           
        }
        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public void getHeaders()
        {


            using (var reader = new StreamReader(openFileDialog1.FileName))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {

                    var records = csv.Read();
                    csv.ReadHeader();
                    
                    string[] headerRow = csv.HeaderRecord;

                    listBoxDriverSelect.DataSource = headerRow;
                    listBoxDriverSelect.Show();
                }
            }
        }

        public string addSessionToDb() {

            SQLiteConnection sqlConn;

            // Create a new database connection and new db if not exists
            sqlConn = new SQLiteConnection("Data Source=VideoDB.db;");
            sqlConn.Open();

            string sqlQuery;
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            
            


            sqlQuery = "INSERT INTO Sessions(sessionName, trackId, driverIndex ,filePath, trackTemp) VALUES (@sessionName, @trackId, @driverIndex , @filePath, @trackTemp)";
            
            sqlCmd.CommandText = sqlQuery;
            sqlCmd.Parameters.AddWithValue("@sessionName", txtSessionNameInput.Text);
            foreach (TrackClass track in TrackClass.trackList) {
                if (track.trackName == listBoxTrackSelect.Text) { 
                sqlCmd.Parameters.AddWithValue("@trackId", TrackClass.findTrackId(listBoxTrackSelect.Text));
                }
            
            
            }
            sqlCmd.Parameters.AddWithValue("@driverIndex", listBoxDriverSelect.Text);
            sqlCmd.Parameters.AddWithValue("@filePath", "None");
            sqlCmd.Parameters.AddWithValue("@trackTemp", 24.0);
            int result = sqlCmd.ExecuteNonQuery();
            sqlConn.Close();


            sqlConn = new SQLiteConnection("Data Source=VideoDB.db;");
            sqlConn.Open();
            sqlCmd = sqlConn.CreateCommand();

            SQLiteDataReader rea;

            sqlQuery = "SELECT COUNT(*) FROM Sessions";
            sqlCmd.CommandText = sqlQuery;
            rea = sqlCmd.ExecuteReader();

            int maxId = 0;
            if (rea.HasRows)
            {
                rea.Read();
                maxId= rea.GetInt32(0);
            }
            
            rea.Close();

            sqlQuery = "UPDATE Sessions SET filePath =@filePath WHERE sessionId=@maxId;";
            sqlCmd.CommandText = sqlQuery;
            string tempPath = "VideoData//LapData//" + maxId.ToString() + ".csv";
            sqlCmd.Parameters.AddWithValue("@filePath",tempPath);
            sqlCmd.Parameters.AddWithValue("@maxId", maxId);
            result = sqlCmd.ExecuteNonQuery();



            if (result == 1)
            {
                MessageBox.Show("Session Added Succesfully");



            }
            else
            {
                MessageBox.Show("Failed to add Session");
            }





            return tempPath;
        
        
        }



        
        //when the user selects a file. refresh the listbox for the list of drivers
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
            getHeaders();
        }

        private void btnRefreshTracks_Click(object sender, EventArgs e)
        {
            listBoxTrackSelect.DataSource = TrackClass.loadTrackList();
            
            listBoxTrackSelect.Refresh();
        }

        
    }
}
