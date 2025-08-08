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
    public partial class frmAddAndUpdateUser : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode = enMode.AddNew;

        private int _UserID = -1;
        clsUser _User;

        public frmAddAndUpdateUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;

        }

        public frmAddAndUpdateUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            _Mode = enMode.Update;

        }

        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                _User = new clsUser();
                lalAddNewUser.Text = "Add New User ";
                this.Text = "Add New User ";

            }
            else

            {
                lalAddNewUser.Text = "Update User ";
                this.Text = "Update User ";
            }


            laUserID.Text = "[???]";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtNote.Text = "";
        }

        private void _LoadData()
        {
            _User = clsUser.FindUserByID(_UserID);
            if (_User == null)
            {
                MessageBox.Show("No User with ID" + _UserID + "User Not Found ");
                return;
            }

            laUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsAdmin.Checked = _User.IsAdmin;
            txtNote.Text = _User.Note;

        }

        private void frmAddAndUpdateUser_Load(object sender, EventArgs e)
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
           
            _User.IsAdmin = chkIsAdmin.Checked;
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                _User.SetPassword(txtPassword.Text);
            }
           
            _User.Note = txtNote.Text;


            if (_User.Save())
            {
                laUserID.Text = _User.UserID.ToString();
                _Mode = enMode.Update;
                lalAddNewUser.Text = "Update User ";
                this.Text = "Update User ";
                MessageBox.Show("Data Saved Successfully.", "Saved");

                DataBack?.Invoke(this, _User.UserID);
                this.Close();
            }

            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error");

        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
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

        private void txtPassword_Validating_Validating(object sender, CancelEventArgs e)
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
                }
                ;
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUser.isUserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    };
                    
                }
            }
        }
    }
}
