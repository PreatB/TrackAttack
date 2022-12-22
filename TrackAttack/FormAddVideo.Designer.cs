namespace TrackAttack
{
    partial class FormAddVideo
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBoxTrackSelect = new System.Windows.Forms.ListBox();
            this.txtVideoName = new System.Windows.Forms.TextBox();
            this.btnFindFile = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.listBoxSessionSelect = new System.Windows.Forms.ListBox();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.btnSaveVideo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxTrackSelect
            // 
            this.listBoxTrackSelect.FormattingEnabled = true;
            this.listBoxTrackSelect.Location = new System.Drawing.Point(301, 68);
            this.listBoxTrackSelect.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTrackSelect.Name = "listBoxTrackSelect";
            this.listBoxTrackSelect.Size = new System.Drawing.Size(178, 17);
            this.listBoxTrackSelect.TabIndex = 0;
            // 
            // txtVideoName
            // 
            this.txtVideoName.Location = new System.Drawing.Point(11, 28);
            this.txtVideoName.Margin = new System.Windows.Forms.Padding(2);
            this.txtVideoName.Name = "txtVideoName";
            this.txtVideoName.Size = new System.Drawing.Size(210, 20);
            this.txtVideoName.TabIndex = 1;
            // 
            // btnFindFile
            // 
            this.btnFindFile.Location = new System.Drawing.Point(470, 20);
            this.btnFindFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindFile.Name = "btnFindFile";
            this.btnFindFile.Size = new System.Drawing.Size(96, 34);
            this.btnFindFile.TabIndex = 2;
            this.btnFindFile.Text = "Select File";
            this.btnFindFile.UseVisualStyleBackColor = true;
            this.btnFindFile.Click += new System.EventHandler(this.btnFindFile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(298, 31);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(57, 13);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "File Name:";
            // 
            // listBoxSessionSelect
            // 
            this.listBoxSessionSelect.FormattingEnabled = true;
            this.listBoxSessionSelect.Location = new System.Drawing.Point(11, 68);
            this.listBoxSessionSelect.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSessionSelect.Name = "listBoxSessionSelect";
            this.listBoxSessionSelect.Size = new System.Drawing.Size(210, 17);
            this.listBoxSessionSelect.TabIndex = 4;
            this.listBoxSessionSelect.SelectedIndexChanged += new System.EventHandler(this.listBoxSessionSelect_SelectedIndexChanged);
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.Location = new System.Drawing.Point(301, 99);
            this.btnAddTrack.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(111, 23);
            this.btnAddTrack.TabIndex = 6;
            this.btnAddTrack.Text = "Add New Track";
            this.btnAddTrack.UseVisualStyleBackColor = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);
            // 
            // btnAddSession
            // 
            this.btnAddSession.Location = new System.Drawing.Point(11, 99);
            this.btnAddSession.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(111, 23);
            this.btnAddSession.TabIndex = 7;
            this.btnAddSession.Text = "Add New Session";
            this.btnAddSession.UseVisualStyleBackColor = true;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // btnSaveVideo
            // 
            this.btnSaveVideo.Location = new System.Drawing.Point(11, 168);
            this.btnSaveVideo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveVideo.Name = "btnSaveVideo";
            this.btnSaveVideo.Size = new System.Drawing.Size(135, 64);
            this.btnSaveVideo.TabIndex = 8;
            this.btnSaveVideo.Text = "Save Video to Database";
            this.btnSaveVideo.UseVisualStyleBackColor = true;
            // 
            // FormAddVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 274);
            this.Controls.Add(this.btnSaveVideo);
            this.Controls.Add(this.btnAddSession);
            this.Controls.Add(this.btnAddTrack);
            this.Controls.Add(this.listBoxSessionSelect);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnFindFile);
            this.Controls.Add(this.txtVideoName);
            this.Controls.Add(this.listBoxTrackSelect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddVideo";
            this.Text = "FormAddVideo";
            this.Load += new System.EventHandler(this.FormAddVideo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxTrackSelect;
        private System.Windows.Forms.TextBox txtVideoName;
        private System.Windows.Forms.Button btnFindFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ListBox listBoxSessionSelect;
        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Button btnSaveVideo;
    }
}