using NUA_Security;
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
    public partial class frmRegister : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode = enMode.AddNew;

        private int _UserID = -1;
        clsUser _User;

        public frmRegister()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmRegister(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            _Mode = enMode.Update;
        }

        private void _ResetDefualtValues()
        {

            _User = new clsUser();

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtNote.Text = "";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData()
        {
            _User = clsUser.FindUserByID(_UserID);
            if (_User == null)
            {
                MessageBox.Show("No User with ID" + _UserID + "User Not Found ");
                return;
            }


            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.PasswordHash;
            txtConfirmPassword.Text = _User.PasswordHash;
            txtNote.Text = _User.Note;

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.Update)
            {
                _LoadData();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _User.UserName = txtUserName.Text;
            _User.SetPassword(txtPassword.Text);
            _User.Note = txtNote.Text;


            if (_User.Save())
            {

                _Mode = enMode.Update;

                MessageBox.Show("Data Saved Successfully.", "Saved");
                this.Close();
            }

            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error");

        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (_User.CkecPassword(txtPassword.Text.Trim()))
            {
                e.Cancel = true;


                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");


            }
            else
            {
                e.Cancel = false;


                errorProvider1.SetError(txtConfirmPassword, null);
            };
            
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            };
            

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };
            


            if (_Mode == enMode.AddNew)
            {

                if (clsUser.isUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                };
                
            }
        }
    }
}

