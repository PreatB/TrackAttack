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
    public partial class Form1 : Form
    {
        public List<VideoClass> videoList;
        public List<SessionClass> sessionList;
        public Form1()
        {
            InitializeComponent();

            Options.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);


            /*
             create video reviews:
                create table to have videos that have been processed and those that need processed
                create button to import new videos
                when viewing videos make shortcuts for each action
                create custom actions
                import file of laptimes and denote which driver you are for auto lap seperation
                filter results (108%, yellow flags, backmarkers,etc)
                side by side comparison of laps
                "jump to" board for video reviews for laps
                
             
             */


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;


            Initializers.initialize();


            videoList = VideoListPanel.loadVideoList();
            sessionList = SessionPanel.loadSessionDB();
        }


        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = Options.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = Options.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        //fix after create table funcs
        private void drawPanelTwo()
        {

            string currentTrack = listBoxTracks.Text;
            IDictionary<int, int> videoCounts = new Dictionary<int, int>();

            foreach (VideoClass videoItem in videoList)
            {
                if (videoCounts.ContainsKey(videoItem.trackId))
                {
                    videoCounts[videoItem.trackId]++;

                }
                else
                {
                    videoCounts[videoItem.trackId] = 1;
                }


                tableLayoutPanel1.RowCount = videoList.Count;




            }

            List<string> listBoxArray = new List<string>();
            foreach (int trackItem in videoCounts.Keys)
            {
                listBoxArray.Add(TrackClass.trackDict[trackItem] + " (" + videoCounts[trackItem].ToString() + ")");


            }
            listBoxTracks.DataSource = listBoxArray;



        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {











        }

        private void btnNewSession_Click(object sender, EventArgs e)
        {
            Form form = new FormAddSession();
            form.Show();

        }
    }
}
