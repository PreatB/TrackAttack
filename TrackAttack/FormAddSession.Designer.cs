namespace TrackAttack
{
    partial class FormAddSession
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxTrackSelect = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextLapEntry = new System.Windows.Forms.RichTextBox();
            this.lblLapCounter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioFileUpload = new System.Windows.Forms.RadioButton();
            this.radioManualEntry = new System.Windows.Forms.RadioButton();
            this.listBoxDriverSelect = new System.Windows.Forms.ListBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnSubmitSession = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 26);
            this.textBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 137);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(135, 20);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "Big long Filename";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(229, 139);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(125, 30);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Session Name";
            // 
            // listBoxTrackSelect
            // 
            this.listBoxTrackSelect.FormattingEnabled = true;
            this.listBoxTrackSelect.ItemHeight = 20;
            this.listBoxTrackSelect.Location = new System.Drawing.Point(97, 224);
            this.listBoxTrackSelect.Name = "listBoxTrackSelect";
            this.listBoxTrackSelect.Size = new System.Drawing.Size(211, 104);
            this.listBoxTrackSelect.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Track:";
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.Location = new System.Drawing.Point(17, 349);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(145, 27);
            this.btnAddTrack.TabIndex = 6;
            this.btnAddTrack.Text = "Add Track";
            this.btnAddTrack.UseVisualStyleBackColor = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(690, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select a .csv file with times or enter your times intot the text box below with a" +
    " new line for each lap";
            // 
            // richTextLapEntry
            // 
            this.richTextLapEntry.Location = new System.Drawing.Point(498, 132);
            this.richTextLapEntry.Name = "richTextLapEntry";
            this.richTextLapEntry.Size = new System.Drawing.Size(118, 290);
            this.richTextLapEntry.TabIndex = 8;
            this.richTextLapEntry.Text = "";
            this.richTextLapEntry.TextChanged += new System.EventHandler(this.richTextLapEntry_TextChanged);
            // 
            // lblLapCounter
            // 
            this.lblLapCounter.AutoSize = true;
            this.lblLapCounter.Location = new System.Drawing.Point(363, 170);
            this.lblLapCounter.Name = "lblLapCounter";
            this.lblLapCounter.Size = new System.Drawing.Size(117, 20);
            this.lblLapCounter.TabIndex = 9;
            this.lblLapCounter.Text = "Lap Number : 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1005, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "On file select. if the file is correct and the header line can be read then havea" +
    " list box for the user to seelct which driver they are. hide the richtxt";
            // 
            // radioFileUpload
            // 
            this.radioFileUpload.AutoSize = true;
            this.radioFileUpload.Location = new System.Drawing.Point(29, 110);
            this.radioFileUpload.Name = "radioFileUpload";
            this.radioFileUpload.Size = new System.Drawing.Size(114, 24);
            this.radioFileUpload.TabIndex = 11;
            this.radioFileUpload.TabStop = true;
            this.radioFileUpload.Text = "File Upload";
            this.radioFileUpload.UseVisualStyleBackColor = true;
            this.radioFileUpload.CheckedChanged += new System.EventHandler(this.radioFileUpload_CheckedChanged);
            // 
            // radioManualEntry
            // 
            this.radioManualEntry.AutoSize = true;
            this.radioManualEntry.Location = new System.Drawing.Point(177, 109);
            this.radioManualEntry.Name = "radioManualEntry";
            this.radioManualEntry.Size = new System.Drawing.Size(127, 24);
            this.radioManualEntry.TabIndex = 12;
            this.radioManualEntry.TabStop = true;
            this.radioManualEntry.Text = "Manual Entry";
            this.radioManualEntry.UseVisualStyleBackColor = true;
            this.radioManualEntry.CheckedChanged += new System.EventHandler(this.radioManualEntry_CheckedChanged);
            // 
            // listBoxDriverSelect
            // 
            this.listBoxDriverSelect.FormattingEnabled = true;
            this.listBoxDriverSelect.ItemHeight = 20;
            this.listBoxDriverSelect.Location = new System.Drawing.Point(498, 193);
            this.listBoxDriverSelect.Name = "listBoxDriverSelect";
            this.listBoxDriverSelect.Size = new System.Drawing.Size(174, 124);
            this.listBoxDriverSelect.TabIndex = 13;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(401, 223);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(49, 20);
            this.lblCounter.TabIndex = 14;
            this.lblCounter.Text = "Lap 1";
            // 
            // btnSubmitSession
            // 
            this.btnSubmitSession.Location = new System.Drawing.Point(84, 437);
            this.btnSubmitSession.Name = "btnSubmitSession";
            this.btnSubmitSession.Size = new System.Drawing.Size(143, 37);
            this.btnSubmitSession.TabIndex = 15;
            this.btnSubmitSession.Text = "Add Session";
            this.btnSubmitSession.UseVisualStyleBackColor = true;
            this.btnSubmitSession.Click += new System.EventHandler(this.btnSubmitSession_Click);
            // 
            // FormAddSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 550);
            this.Controls.Add(this.btnSubmitSession);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.listBoxDriverSelect);
            this.Controls.Add(this.radioManualEntry);
            this.Controls.Add(this.radioFileUpload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLapCounter);
            this.Controls.Add(this.richTextLapEntry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddTrack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTrackSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.textBox1);
            this.Name = "FormAddSession";
            this.Text = "FormAddSession";
            this.Load += new System.EventHandler(this.FormAddSession_Load);
            this.Enter += new System.EventHandler(this.FormAddSession_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTrackSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextLapEntry;
        private System.Windows.Forms.Label lblLapCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioFileUpload;
        private System.Windows.Forms.RadioButton radioManualEntry;
        private System.Windows.Forms.ListBox listBoxDriverSelect;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnSubmitSession;
    }
}