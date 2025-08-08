namespace NotesUserApp
{
    partial class frmAddAndUpdateUser
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
            this.lalAddNewUser = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lalUsuerID = new System.Windows.Forms.Label();
            this.lalUserName = new System.Windows.Forms.Label();
            this.lalPassword = new System.Windows.Forms.Label();
            this.lalNote = new System.Windows.Forms.Label();
            this.laUserID = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lalConfirmPassword = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lalAddNewUser
            // 
            this.lalAddNewUser.AutoSize = true;
            this.lalAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalAddNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lalAddNewUser.Location = new System.Drawing.Point(290, 41);
            this.lalAddNewUser.Name = "lalAddNewUser";
            this.lalAddNewUser.Size = new System.Drawing.Size(194, 32);
            this.lalAddNewUser.TabIndex = 1;
            this.lalAddNewUser.Text = "Add New User";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(561, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lalUsuerID
            // 
            this.lalUsuerID.AutoSize = true;
            this.lalUsuerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalUsuerID.Location = new System.Drawing.Point(38, 83);
            this.lalUsuerID.Name = "lalUsuerID";
            this.lalUsuerID.Size = new System.Drawing.Size(65, 22);
            this.lalUsuerID.TabIndex = 3;
            this.lalUsuerID.Text = "UserID";
            // 
            // lalUserName
            // 
            this.lalUserName.AutoSize = true;
            this.lalUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalUserName.Location = new System.Drawing.Point(38, 146);
            this.lalUserName.Name = "lalUserName";
            this.lalUserName.Size = new System.Drawing.Size(95, 22);
            this.lalUserName.TabIndex = 4;
            this.lalUserName.Text = "UserName";
            // 
            // lalPassword
            // 
            this.lalPassword.AutoSize = true;
            this.lalPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalPassword.Location = new System.Drawing.Point(38, 217);
            this.lalPassword.Name = "lalPassword";
            this.lalPassword.Size = new System.Drawing.Size(89, 22);
            this.lalPassword.TabIndex = 5;
            this.lalPassword.Text = "Password";
            // 
            // lalNote
            // 
            this.lalNote.AutoSize = true;
            this.lalNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalNote.Location = new System.Drawing.Point(38, 435);
            this.lalNote.Name = "lalNote";
            this.lalNote.Size = new System.Drawing.Size(48, 22);
            this.lalNote.TabIndex = 6;
            this.lalNote.Text = "Note";
            // 
            // laUserID
            // 
            this.laUserID.AutoSize = true;
            this.laUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laUserID.Location = new System.Drawing.Point(220, 83);
            this.laUserID.Name = "laUserID";
            this.laUserID.Size = new System.Drawing.Size(54, 22);
            this.laUserID.TabIndex = 7;
            this.laUserID.Text = "[???\']";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(224, 145);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 22);
            this.txtUserName.TabIndex = 8;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(224, 219);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(158, 22);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating_Validating);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(224, 289);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(158, 22);
            this.txtConfirmPassword.TabIndex = 10;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // lalConfirmPassword
            // 
            this.lalConfirmPassword.AutoSize = true;
            this.lalConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalConfirmPassword.Location = new System.Drawing.Point(38, 287);
            this.lalConfirmPassword.Name = "lalConfirmPassword";
            this.lalConfirmPassword.Size = new System.Drawing.Size(156, 22);
            this.lalConfirmPassword.TabIndex = 11;
            this.lalConfirmPassword.Text = "Confirm Password";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(168, 395);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(256, 90);
            this.txtNote.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.AutoSize = true;
            this.chkIsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsAdmin.Location = new System.Drawing.Point(224, 343);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(123, 26);
            this.chkIsAdmin.TabIndex = 13;
            this.chkIsAdmin.Text = "chkIsAdmin";
            this.chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // frmAddAndUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.chkIsAdmin);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lalConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.laUserID);
            this.Controls.Add(this.lalNote);
            this.Controls.Add(this.lalPassword);
            this.Controls.Add(this.lalUserName);
            this.Controls.Add(this.lalUsuerID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lalAddNewUser);
            this.Name = "frmAddAndUpdateUser";
            this.Text = "frmAddAndUpdateUser";
            this.Load += new System.EventHandler(this.frmAddAndUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lalAddNewUser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lalUsuerID;
        private System.Windows.Forms.Label lalUserName;
        private System.Windows.Forms.Label lalPassword;
        private System.Windows.Forms.Label lalNote;
        private System.Windows.Forms.Label laUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lalConfirmPassword;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chkIsAdmin;
    }
}