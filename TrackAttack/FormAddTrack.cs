using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TrackAttack
{
    public partial class FormAddTrack : Form
    {
        public FormAddTrack()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlConn;

            // Create a new database connection and new db if not exists
            sqlConn = new SQLiteConnection("Data Source=VideoDB.db;");
            sqlConn.Open();

            string sqlQuery;
            sqlQuery = "INSERT OR IGNORE INTO Tracks(trackName, trackLength) VALUES (@trackName, @trackLength)";
            SQLiteCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = sqlQuery;
            sqlCmd.Parameters.AddWithValue("@trackName", richtxtTrackName.ToString());
            sqlCmd.Parameters.AddWithValue("@trackLength", txtTrackLength);
            int result = sqlCmd.ExecuteNonQuery();

            if (result == 1)
            {
                MessageBox.Show("Track Added Succesfully");



            }
            else {
                MessageBox.Show("Failed to add track");
            }

            this.Close();


        }
    }
}
