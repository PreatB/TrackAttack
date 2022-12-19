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

            //add track Listbox
            List<string> tempList = new List<string>();
            tempList.Add("Add New Track");
            foreach (string tempString in TrackClass.trackDict.Values) { 
            tempList.Add(tempString);
            }
            listBoxTrackSelect.DataSource = tempList;

            



            //listBoxSessionSelect





            //add Session Listbox
            //get file
            //db update
            

        }

        private void listBoxTrackSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool hideTrackInputs = (listBoxTrackSelect.Text == "Add New Track");

                btnAddTrack.Visible = hideTrackInputs;
                txtBoxNewTrack.Visible = hideTrackInputs;

        }
    }
}
