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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFindFile = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.listBoxSessionSelect = new System.Windows.Forms.ListBox();
            this.txtBoxNewTrack = new System.Windows.Forms.TextBox();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxTrackSelect
            // 
            this.listBoxTrackSelect.FormattingEnabled = true;
            this.listBoxTrackSelect.ItemHeight = 20;
            this.listBoxTrackSelect.Location = new System.Drawing.Point(380, 39);
            this.listBoxTrackSelect.Name = "listBoxTrackSelect";
            this.listBoxTrackSelect.Size = new System.Drawing.Size(265, 24);
            this.listBoxTrackSelect.TabIndex = 0;
            this.listBoxTrackSelect.SelectedIndexChanged += new System.EventHandler(this.listBoxTrackSelect_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 26);
            this.textBox1.TabIndex = 1;
            // 
            // btnFindFile
            // 
            this.btnFindFile.Location = new System.Drawing.Point(199, 101);
            this.btnFindFile.Name = "btnFindFile";
            this.btnFindFile.Size = new System.Drawing.Size(126, 26);
            this.btnFindFile.TabIndex = 2;
            this.btnFindFile.Text = "Select File";
            this.btnFindFile.UseVisualStyleBackColor = true;
            this.btnFindFile.Click += new System.EventHandler(this.btnFindFile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 101);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(51, 20);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "label1";
            // 
            // listBoxSessionSelect
            // 
            this.listBoxSessionSelect.FormattingEnabled = true;
            this.listBoxSessionSelect.ItemHeight = 20;
            this.listBoxSessionSelect.Location = new System.Drawing.Point(12, 153);
            this.listBoxSessionSelect.Name = "listBoxSessionSelect";
            this.listBoxSessionSelect.Size = new System.Drawing.Size(313, 24);
            this.listBoxSessionSelect.TabIndex = 4;
            // 
            // txtBoxNewTrack
            // 
            this.txtBoxNewTrack.Location = new System.Drawing.Point(380, 153);
            this.txtBoxNewTrack.Name = "txtBoxNewTrack";
            this.txtBoxNewTrack.Size = new System.Drawing.Size(265, 26);
            this.txtBoxNewTrack.TabIndex = 5;
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.Location = new System.Drawing.Point(461, 200);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(125, 35);
            this.btnAddTrack.TabIndex = 6;
            this.btnAddTrack.Text = "Add Track";
            this.btnAddTrack.UseVisualStyleBackColor = true;
            // 
            // btnAddSession
            // 
            this.btnAddSession.Location = new System.Drawing.Point(78, 200);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(126, 35);
            this.btnAddSession.TabIndex = 7;
            this.btnAddSession.Text = "Add Session";
            this.btnAddSession.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 98);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save Video to Database";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAddVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddSession);
            this.Controls.Add(this.btnAddTrack);
            this.Controls.Add(this.txtBoxNewTrack);
            this.Controls.Add(this.listBoxSessionSelect);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnFindFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxTrackSelect);
            this.Name = "FormAddVideo";
            this.Text = "FormAddVideo";
            this.Load += new System.EventHandler(this.FormAddVideo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxTrackSelect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFindFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ListBox listBoxSessionSelect;
        private System.Windows.Forms.TextBox txtBoxNewTrack;
        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Button button1;
    }
}