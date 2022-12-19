namespace TrackAttack
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.Options = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtVideoSearch = new System.Windows.Forms.TextBox();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.listBoxTracks = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnNewSession = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.Options.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 39);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Red;
            this.btnCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.Location = new System.Drawing.Point(1128, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(50, 39);
            this.btnCloseForm.TabIndex = 1;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Track Attack";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 39);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1178, 580);
            this.panelMain.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.Options);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1178, 580);
            this.panelContent.TabIndex = 1;
            // 
            // Options
            // 
            this.Options.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.Options.Controls.Add(this.tabPage1);
            this.Options.Controls.Add(this.tabPage2);
            this.Options.Controls.Add(this.tabPage3);
            this.Options.Controls.Add(this.tabPage4);
            this.Options.Controls.Add(this.tabPage5);
            this.Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Options.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.Options.ItemSize = new System.Drawing.Size(120, 150);
            this.Options.Location = new System.Drawing.Point(0, 0);
            this.Options.Margin = new System.Windows.Forms.Padding(0);
            this.Options.Multiline = true;
            this.Options.Name = "Options";
            this.Options.Padding = new System.Drawing.Point(0, 0);
            this.Options.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Options.SelectedIndex = 0;
            this.Options.Size = new System.Drawing.Size(1178, 580);
            this.Options.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Options.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtVideoSearch);
            this.tabPage2.Controls.Add(this.btnAddVideo);
            this.tabPage2.Controls.Add(this.listBoxTracks);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1020, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Videos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtVideoSearch
            // 
            this.txtVideoSearch.Location = new System.Drawing.Point(315, 22);
            this.txtVideoSearch.Name = "txtVideoSearch";
            this.txtVideoSearch.Size = new System.Drawing.Size(191, 26);
            this.txtVideoSearch.TabIndex = 2;
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.Location = new System.Drawing.Point(827, 6);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(162, 57);
            this.btnAddVideo.TabIndex = 1;
            this.btnAddVideo.Text = "New Video";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // listBoxTracks
            // 
            this.listBoxTracks.FormattingEnabled = true;
            this.listBoxTracks.ItemHeight = 20;
            this.listBoxTracks.Location = new System.Drawing.Point(18, 22);
            this.listBoxTracks.Name = "listBoxTracks";
            this.listBoxTracks.Size = new System.Drawing.Size(229, 24);
            this.listBoxTracks.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.81329F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.18671F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(993, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnNewSession);
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1020, 572);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(154, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1020, 572);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(154, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1020, 572);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnNewSession
            // 
            this.btnNewSession.Location = new System.Drawing.Point(849, 16);
            this.btnNewSession.Name = "btnNewSession";
            this.btnNewSession.Size = new System.Drawing.Size(163, 34);
            this.btnNewSession.TabIndex = 0;
            this.btnNewSession.Text = "New Session";
            this.btnNewSession.UseVisualStyleBackColor = true;
            this.btnNewSession.Click += new System.EventHandler(this.btnNewSession_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 619);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.Options.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public  System.Windows.Forms.Panel panel1;
        public  System.Windows.Forms.Button btnCloseForm;
        public  System.Windows.Forms.Label lblTitle;
        public  System.Windows.Forms.Panel panelMain;
        public  System.Windows.Forms.Panel panelContent;
        public  System.Windows.Forms.TabControl Options;
        public  System.Windows.Forms.TabPage tabPage1;
        public  System.Windows.Forms.TabPage tabPage2;
        public  System.Windows.Forms.TabPage tabPage3;
        public  System.Windows.Forms.TabPage tabPage4;
        public  System.Windows.Forms.TabPage tabPage5;
        public  System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public  System.Windows.Forms.TextBox txtVideoSearch;
        public  System.Windows.Forms.Button btnAddVideo;
        public  System.Windows.Forms.ListBox listBoxTracks;
        private System.Windows.Forms.Button btnNewSession;
    }
}

