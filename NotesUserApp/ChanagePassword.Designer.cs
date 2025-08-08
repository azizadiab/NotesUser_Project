namespace NotesUserApp
{
    partial class ChanagePassword
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.taPassportChange = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lalChanagePassword = new System.Windows.Forms.Label();
            this.lalConfirmNewPassword = new System.Windows.Forms.Label();
            this.lalNewPassword = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lalCurrentPassword = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.taPassportChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.taPassportChange);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // taPassportChange
            // 
            this.taPassportChange.Controls.Add(this.btnClose);
            this.taPassportChange.Controls.Add(this.btnSave);
            this.taPassportChange.Controls.Add(this.lalChanagePassword);
            this.taPassportChange.Controls.Add(this.lalConfirmNewPassword);
            this.taPassportChange.Controls.Add(this.lalNewPassword);
            this.taPassportChange.Controls.Add(this.txtConfirmNewPassword);
            this.taPassportChange.Controls.Add(this.txtNewPassword);
            this.taPassportChange.Controls.Add(this.txtCurrentPassword);
            this.taPassportChange.Controls.Add(this.lalCurrentPassword);
            this.taPassportChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taPassportChange.Location = new System.Drawing.Point(4, 25);
            this.taPassportChange.Name = "taPassportChange";
            this.taPassportChange.Padding = new System.Windows.Forms.Padding(3);
            this.taPassportChange.Size = new System.Drawing.Size(759, 364);
            this.taPassportChange.TabIndex = 1;
            this.taPassportChange.Text = "Passport Change";
            this.taPassportChange.UseVisualStyleBackColor = true;
            this.taPassportChange.Click += new System.EventHandler(this.taPassportChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(327, 286);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 50);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(144, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 50);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lalChanagePassword
            // 
            this.lalChanagePassword.AutoSize = true;
            this.lalChanagePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalChanagePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lalChanagePassword.Location = new System.Drawing.Point(237, 24);
            this.lalChanagePassword.Name = "lalChanagePassword";
            this.lalChanagePassword.Size = new System.Drawing.Size(223, 29);
            this.lalChanagePassword.TabIndex = 6;
            this.lalChanagePassword.Text = "Chanage Password";
            // 
            // lalConfirmNewPassword
            // 
            this.lalConfirmNewPassword.AutoSize = true;
            this.lalConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalConfirmNewPassword.Location = new System.Drawing.Point(35, 218);
            this.lalConfirmNewPassword.Name = "lalConfirmNewPassword";
            this.lalConfirmNewPassword.Size = new System.Drawing.Size(156, 22);
            this.lalConfirmNewPassword.TabIndex = 5;
            this.lalConfirmNewPassword.Text = "Confirm Password";
            // 
            // lalNewPassword
            // 
            this.lalNewPassword.AutoSize = true;
            this.lalNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalNewPassword.Location = new System.Drawing.Point(35, 158);
            this.lalNewPassword.Name = "lalNewPassword";
            this.lalNewPassword.Size = new System.Drawing.Size(130, 22);
            this.lalNewPassword.TabIndex = 4;
            this.lalNewPassword.Text = "New Password";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(242, 220);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(100, 28);
            this.txtConfirmNewPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(242, 158);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(100, 28);
            this.txtNewPassword.TabIndex = 2;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(242, 91);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(100, 28);
            this.txtCurrentPassword.TabIndex = 1;
            // 
            // lalCurrentPassword
            // 
            this.lalCurrentPassword.AutoSize = true;
            this.lalCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalCurrentPassword.Location = new System.Drawing.Point(35, 89);
            this.lalCurrentPassword.Name = "lalCurrentPassword";
            this.lalCurrentPassword.Size = new System.Drawing.Size(154, 22);
            this.lalCurrentPassword.TabIndex = 0;
            this.lalCurrentPassword.Text = "Current Password";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ChanagePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 430);
            this.Controls.Add(this.tabControl1);
            this.Name = "ChanagePassword";
            this.Text = "ChanagePassword";
            this.Load += new System.EventHandler(this.ChanagePassword_Load);
            this.tabControl1.ResumeLayout(false);
            this.taPassportChange.ResumeLayout(false);
            this.taPassportChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage taPassportChange;
        private System.Windows.Forms.Label lalConfirmNewPassword;
        private System.Windows.Forms.Label lalNewPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lalCurrentPassword;
        private System.Windows.Forms.Label lalChanagePassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}