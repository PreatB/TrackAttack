using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackAttack
{
    public partial class FormAddVideo : Form
    {
        public FormAddVideo()
        {
            InitializeComponent();
        }

        private void btnFindFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void FormAddVideo_Load(object sender, EventArgs e)
        {
            SessionClass.loadSessionsDB();
            listBoxSessionSelect.DataSource = SessionClass.sessionNameList;
            
            listBoxTrackSelect.DataSource = TrackClass.trackNameList;

        }

       

        

        private void listBoxSessionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            Form form = new FormAddSession();
            form.Show();
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            Form form = new FormAddSession();
            form.Show();
        }
    }
}
