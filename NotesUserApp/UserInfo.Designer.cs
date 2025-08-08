namespace NotesUserApp
{
    partial class frmUserInfo
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
            this.lalUserInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.controlUserInfoCard1 = new NotesUserApp.ControlUserInfoCard();
            this.SuspendLayout();
            // 
            // lalUserInfo
            // 
            this.lalUserInfo.AutoSize = true;
            this.lalUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lalUserInfo.Location = new System.Drawing.Point(262, 9);
            this.lalUserInfo.Name = "lalUserInfo";
            this.lalUserInfo.Size = new System.Drawing.Size(176, 29);
            this.lalUserInfo.TabIndex = 1;
            this.lalUserInfo.Text = "Show User Info";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(421, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // controlUserInfoCard1
            // 
            this.controlUserInfoCard1.Location = new System.Drawing.Point(73, 73);
            this.controlUserInfoCard1.Name = "controlUserInfoCard1";
            this.controlUserInfoCard1.Size = new System.Drawing.Size(609, 322);
            this.controlUserInfoCard1.TabIndex = 0;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lalUserInfo);
            this.Controls.Add(this.controlUserInfoCard1);
            this.Name = "frmUserInfo";
            this.Text = "UserInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlUserInfoCard controlUserInfoCard1;
        private System.Windows.Forms.Label lalUserInfo;
        private System.Windows.Forms.Button btnClose;
    }
}