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
    public partial class ControlUserInfoCard : UserControl
    {
        private int _UserID;
        private clsUser _User;

        public int UserID
        {
            get { return _UserID; }
        }
        

        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.FindUserByID(UserID);
            if(_User==null)
            {
                ResetPersonInfo();
                MessageBox.Show("No User with ID" + _UserID + "Error");
                return;
            }
            _FillUserInfo();

        }

        private void _FillUserInfo()
        {
            lalUserID.Text = _User.UserID.ToString();
            lalUserName.Text = _User.UserName;
            lalIsAdmin.Text = _User.IsAdmin.ToString();
            lalNote.Text = _User.Note;
        }

        private void ResetPersonInfo()
        {

            lalUserID.Text = "[???]";
            lalUserName.Text = "[???]";
            lalIsAdmin.Text = "[???]";
            lalNote.Text = "[???]";
        }
        public ControlUserInfoCard()
        {
            InitializeComponent();
        }

        private void UserInfoCard_Load(object sender, EventArgs e)
        {

        }
    }
}
