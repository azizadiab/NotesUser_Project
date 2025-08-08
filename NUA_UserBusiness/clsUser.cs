using NUA_Security;
using NUA_UserData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUA_UserBusiness
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 }
       
        public enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Note { get; set; }

        public bool IsAdmin { get; set; }

        public clsUser()
        {
            this.UserID = -1;
            this.UserName = "";
            this.PasswordHash = "";
            this.Note = "";
            Mode = enMode.AddNew;

        }

        public clsUser(int UserID, string UserName,
                               string PasswordHash, string Note, bool IsAdmin)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.PasswordHash = PasswordHash;
            this.Note = Note;
            this.IsAdmin = IsAdmin;
            Mode = enMode.Update;

        }

        public static clsUser FindUserByID(int UserID)
        {
            string UserName = "", PasswordHash = "", Note = "";
            bool IsAdmin = false;

            if (clsUserData.GetUserByID(UserID, ref UserName, ref PasswordHash, ref Note, ref IsAdmin))
            {

                return new clsUser(UserID, UserName, PasswordHash, Note, IsAdmin);

            }
            return null;

        }

        public static clsUser FindUserByUserNameandPassword(string UserName, string Password)
        {
            int UserID = -1;
            string StorePasswortHash = "", Note = "";
            bool IsAdmin = false;

            if (clsUserData.GetUserByUserName(ref UserID, UserName, ref StorePasswortHash, 
                                                  ref Note, ref IsAdmin))
            {

                if (clsSecurity.Has256Password(Password) == StorePasswortHash)
                {

                    //Returns a user object if authentication succeeds
                    return new clsUser(UserID, UserName, StorePasswortHash, Note, IsAdmin);
                }
            }
            return null;

        }

        private bool _AddNewUser()
        {

            this.UserID = clsUserData.AddNewUser(this.UserName, this.PasswordHash, this.Note, this.IsAdmin);
            return (this.UserID > 0);

        }

        private bool _UpdateUser()
        {

            return clsUserData.UpdateUser(this.UserID, this.UserName, 
                                this.PasswordHash, this.Note, this.IsAdmin);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static DataTable GetAllUsers()
        {

            return clsUserData.GetAllUsers();

        }

        public static bool DeleteUser(int UserID)
        {

            return clsUserData.DeleteUserByID(UserID);
        }

        public static bool isUserExist(string UserName)
        {
            return clsUserData.isUserExist(UserName);

        }


        //public void SetPassword(string Password)
        //{
        //    this.Salt = clsSecurity.GenerateSalt();
        //    this.PasswordHash = clsSecurity.Has256Password(Password, this.Salt);
        //}

        public void SetPassword(string Password)
        {

            this.PasswordHash = clsSecurity.Has256Password(Password);

        }

        public bool CkecPassword(string Password)
        {
            return this.PasswordHash == clsSecurity.Has256Password(Password);

        }

    }
}
