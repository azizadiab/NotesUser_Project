namespace NotesUserApp
{
    partial class ControlUserInfoCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.laUserId = new System.Windows.Forms.Label();
            this.laUserName = new System.Windows.Forms.Label();
            this.laIsAdmin = new System.Windows.Forms.Label();
            this.lalUserID = new System.Windows.Forms.Label();
            this.lalUserName = new System.Windows.Forms.Label();
            this.lalIsAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lalNote = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // laUserId
            // 
            this.laUserId.AutoSize = true;
            this.laUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laUserId.Location = new System.Drawing.Point(38, 64);
            this.laUserId.Name = "laUserId";
            this.laUserId.Size = new System.Drawing.Size(65, 22);
            this.laUserId.TabIndex = 0;
            this.laUserId.Text = "UserID";
            // 
            // laUserName
            // 
            this.laUserName.AutoSize = true;
            this.laUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laUserName.Location = new System.Drawing.Point(38, 127);
            this.laUserName.Name = "laUserName";
            this.laUserName.Size = new System.Drawing.Size(95, 22);
            this.laUserName.TabIndex = 1;
            this.laUserName.Text = "UserName";
            // 
            // laIsAdmin
            // 
            this.laIsAdmin.AutoSize = true;
            this.laIsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laIsAdmin.Location = new System.Drawing.Point(38, 184);
            this.laIsAdmin.Name = "laIsAdmin";
            this.laIsAdmin.Size = new System.Drawing.Size(73, 22);
            this.laIsAdmin.TabIndex = 2;
            this.laIsAdmin.Text = "IsAdmin";
            // 
            // lalUserID
            // 
            this.lalUserID.AutoSize = true;
            this.lalUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lalUserID.Location = new System.Drawing.Point(197, 64);
            this.lalUserID.Name = "lalUserID";
            this.lalUserID.Size = new System.Drawing.Size(50, 22);
            this.lalUserID.TabIndex = 3;
            this.lalUserID.Text = "[???]";
            // 
            // lalUserName
            // 
            this.lalUserName.AutoSize = true;
            this.lalUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalUserName.Location = new System.Drawing.Point(197, 127);
            this.lalUserName.Name = "lalUserName";
            this.lalUserName.Size = new System.Drawing.Size(50, 22);
            this.lalUserName.TabIndex = 4;
            this.lalUserName.Text = "[???]";
            // 
            // lalIsAdmin
            // 
            this.lalIsAdmin.AutoSize = true;
            this.lalIsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalIsAdmin.Location = new System.Drawing.Point(197, 184);
            this.lalIsAdmin.Name = "lalIsAdmin";
            this.lalIsAdmin.Size = new System.Drawing.Size(50, 22);
            this.lalIsAdmin.TabIndex = 5;
            this.lalIsAdmin.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Note";
            // 
            // lalNote
            // 
            this.lalNote.AutoSize = true;
            this.lalNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalNote.Location = new System.Drawing.Point(197, 237);
            this.lalNote.Name = "lalNote";
            this.lalNote.Size = new System.Drawing.Size(50, 22);
            this.lalNote.TabIndex = 7;
            this.lalNote.Text = "[???]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NotesUserApp.Properties.Resources.Male_512;
            this.pictureBox1.Location = new System.Drawing.Point(388, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ControlUserInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lalNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lalIsAdmin);
            this.Controls.Add(this.lalUserName);
            this.Controls.Add(this.lalUserID);
            this.Controls.Add(this.laIsAdmin);
            this.Controls.Add(this.laUserName);
            this.Controls.Add(this.laUserId);
            this.Name = "ControlUserInfoCard";
            this.Size = new System.Drawing.Size(609, 322);
            this.Load += new System.EventHandler(this.UserInfoCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laUserId;
        private System.Windows.Forms.Label laUserName;
        private System.Windows.Forms.Label laIsAdmin;
        private System.Windows.Forms.Label lalUserID;
        private System.Windows.Forms.Label lalUserName;
        private System.Windows.Forms.Label lalIsAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lalNote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
