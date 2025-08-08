namespace NotesUserApp
{
    partial class frmRegister
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
            this.lalUserName = new System.Windows.Forms.Label();
            this.lalPassword = new System.Windows.Forms.Label();
            this.lalRegister = new System.Windows.Forms.Label();
            this.lalConfirmPassword = new System.Windows.Forms.Label();
            this.lalNote = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lalUserName
            // 
            this.lalUserName.AutoSize = true;
            this.lalUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalUserName.Location = new System.Drawing.Point(12, 99);
            this.lalUserName.Name = "lalUserName";
            this.lalUserName.Size = new System.Drawing.Size(95, 22);
            this.lalUserName.TabIndex = 0;
            this.lalUserName.Text = "UserName";
            // 
            // lalPassword
            // 
            this.lalPassword.AutoSize = true;
            this.lalPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalPassword.Location = new System.Drawing.Point(12, 167);
            this.lalPassword.Name = "lalPassword";
            this.lalPassword.Size = new System.Drawing.Size(89, 22);
            this.lalPassword.TabIndex = 1;
            this.lalPassword.Text = "Password";
            // 
            // lalRegister
            // 
            this.lalRegister.AutoSize = true;
            this.lalRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lalRegister.Location = new System.Drawing.Point(290, 35);
            this.lalRegister.Name = "lalRegister";
            this.lalRegister.Size = new System.Drawing.Size(217, 29);
            this.lalRegister.TabIndex = 2;
            this.lalRegister.Text = "Register New User";
            // 
            // lalConfirmPassword
            // 
            this.lalConfirmPassword.AutoSize = true;
            this.lalConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalConfirmPassword.Location = new System.Drawing.Point(12, 237);
            this.lalConfirmPassword.Name = "lalConfirmPassword";
            this.lalConfirmPassword.Size = new System.Drawing.Size(151, 22);
            this.lalConfirmPassword.TabIndex = 3;
            this.lalConfirmPassword.Text = "ConfirmPassword";
            // 
            // lalNote
            // 
            this.lalNote.AutoSize = true;
            this.lalNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalNote.Location = new System.Drawing.Point(30, 374);
            this.lalNote.Name = "lalNote";
            this.lalNote.Size = new System.Drawing.Size(48, 22);
            this.lalNote.TabIndex = 4;
            this.lalNote.Text = "Note";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(240, 118);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 22);
            this.txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(240, 169);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(140, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(240, 239);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(140, 22);
            this.txtConfirmPassword.TabIndex = 7;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(212, 340);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(213, 84);
            this.txtNote.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(342, 462);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 47);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(155, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 47);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lalNote);
            this.Controls.Add(this.lalConfirmPassword);
            this.Controls.Add(this.lalRegister);
            this.Controls.Add(this.lalPassword);
            this.Controls.Add(this.lalUserName);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalUserName;
        private System.Windows.Forms.Label lalPassword;
        private System.Windows.Forms.Label lalRegister;
        private System.Windows.Forms.Label lalConfirmPassword;
        private System.Windows.Forms.Label lalNote;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}