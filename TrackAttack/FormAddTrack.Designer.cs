namespace TrackAttack
{
    partial class FormAddTrack
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
            this.richtxtTrackName = new System.Windows.Forms.RichTextBox();
            this.txtTrackLength = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTrackName = new System.Windows.Forms.Label();
            this.lblTrackLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richtxtTrackName
            // 
            this.richtxtTrackName.Location = new System.Drawing.Point(23, 50);
            this.richtxtTrackName.Name = "richtxtTrackName";
            this.richtxtTrackName.Size = new System.Drawing.Size(268, 62);
            this.richtxtTrackName.TabIndex = 0;
            this.richtxtTrackName.Text = "";
            // 
            // txtTrackLength
            // 
            this.txtTrackLength.Location = new System.Drawing.Point(23, 176);
            this.txtTrackLength.Name = "txtTrackLength";
            this.txtTrackLength.Size = new System.Drawing.Size(198, 26);
            this.txtTrackLength.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(72, 255);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(149, 104);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Add Track";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTrackName
            // 
            this.lblTrackName.AutoSize = true;
            this.lblTrackName.Location = new System.Drawing.Point(23, 13);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.Size = new System.Drawing.Size(141, 20);
            this.lblTrackName.TabIndex = 3;
            this.lblTrackName.Text = "Enter Track Name:";
            // 
            // lblTrackLength
            // 
            this.lblTrackLength.AutoSize = true;
            this.lblTrackLength.Location = new System.Drawing.Point(23, 150);
            this.lblTrackLength.Name = "lblTrackLength";
            this.lblTrackLength.Size = new System.Drawing.Size(198, 20);
            this.lblTrackLength.TabIndex = 4;
            this.lblTrackLength.Text = "Enter track length (metres)";
            // 
            // FormAddTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 450);
            this.Controls.Add(this.lblTrackLength);
            this.Controls.Add(this.lblTrackName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTrackLength);
            this.Controls.Add(this.richtxtTrackName);
            this.Name = "FormAddTrack";
            this.Text = "FormAddTrack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtTrackName;
        private System.Windows.Forms.TextBox txtTrackLength;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTrackName;
        private System.Windows.Forms.Label lblTrackLength;
    }
}