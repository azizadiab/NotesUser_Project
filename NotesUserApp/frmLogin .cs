using NUA_UserBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesUserApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            clsUser User = clsUser.FindUserByUserNameandPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (User != null)
            {

                if (chkRemember.Checked)
                {
                    //store username and password
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                }
                else
                {

                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                clsGlobal.CurrentUser = User;
                this.Hide();
                frmUsers frm = new frmUsers();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                txtPassword.Clear();
                txtUserName.Focus();

                MessageBox.Show("Invalid Username or Password., Please try again", "Login Failed",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkRemember.Checked = true;

            }
            else
            {
                chkRemember.Checked = false;

            }

        }

        private void btnRegisterNewUser_Click(object sender, EventArgs e)
        {

            frmRegister frm = new frmRegister();
            frm.ShowDialog();
        }
    }

}
