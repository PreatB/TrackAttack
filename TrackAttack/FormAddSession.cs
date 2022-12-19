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

            

        }

        private void FormAddSession_Enter(object sender, EventArgs e)
        {

            


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

        }

        private void btnSubmitSession_Click(object sender, EventArgs e)
        {
            if (radioFileUpload.Checked) { 
            
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
            



            


        

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            getHeaders();
        }
    }
}
