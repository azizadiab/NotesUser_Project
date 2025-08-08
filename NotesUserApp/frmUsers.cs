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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void LoadUsers()
        {

            DataTable dtUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = dtUsers;
            lalRecord.Text = "#Record Count: " + dgvUsers.Rows.Count.ToString();
            if(dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 50;

                dgvUsers.Columns[1].HeaderText = "User Name";
                dgvUsers.Columns[1].Width = 100;

                dgvUsers.Columns[2].HeaderText = "Pasword Hash";
                dgvUsers.Columns[2].Width = 150;

                dgvUsers.Columns[3].HeaderText = "Note";
                dgvUsers.Columns[3].Width = 200;

                dgvUsers.Columns[4].HeaderText = "Is Admin";
                dgvUsers.Columns[4].Width = 80;

            }

        }


        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();


            if (!clsGlobal.CurrentUser.IsAdmin)
            {

                btnAddNew.Visible = false;
                contextMenuStrip1.Items["addNewUserToolStripMenuItem"].Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure you want to delete User with ID [ " + dgvUsers.CurrentRow.Cells[0].Value +
             " ]", "Confirm Note", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();

                }
                else
                {
                    MessageBox.Show("Note could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            frmAddAndUpdateUser frm = new frmAddAndUpdateUser(UserID);
            frm.DataBack += Form_SendBack;
            frm.ShowDialog();

        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmAddAndUpdateUser frm = new frmAddAndUpdateUser();

            frm.DataBack += Form_SendBack;
            frm.ShowDialog();

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateUser frm = new frmAddAndUpdateUser();

            frm.DataBack += Form_SendBack;
            frm.ShowDialog();
        }

       private void Form_SendBack(object sender, int UserID)
        {

            LoadUsers();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            ChanagePassword frm = new ChanagePassword(UserID);
            frm.ShowDialog();
            LoadUsers();
        }

        private void showUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = clsGlobal.CurrentUser.UserID;
            frmUserInfo frm = new frmUserInfo(UserID);
            frm.ShowDialog();
        }
    }
    }

