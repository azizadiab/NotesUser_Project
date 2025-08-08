using System;
using System.Data;
using System.Data.SqlClient;

namespace NUA_UserData
{
    public class clsUserData
    {
        public static bool GetUserByID(int UserID, ref string UserName,
                                 ref string PasswordHash, ref string Note, ref bool IsAdmin)
        {
            bool isFound = false;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand Command = new SqlCommand("SP_GetUserByID", Connection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@UserID", UserID);

                try
                {
                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            isFound = true;

                            UserName = (string)Reader["UserName"];
                            PasswordHash = (string)Reader["PasswordHash"];
                            Note = (string)Reader["Note"];
                            IsAdmin = (bool)Reader["IsAdmin"];
                                
                        }
                        else
                        {
                            isFound = false;
                        }

                    }

                }
                catch (Exception ex)
                {

                    throw new Exception("An error occurred while Get user By ID.", ex);

                }

                return isFound;
            }
        }

        public static bool GetUserByUserName(ref int UserID, string UserName,
                                ref string PasswordHash, ref string Note, ref bool IsAdmin)
        {
            bool isFound = false;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand Command = new SqlCommand("SP_GetUserByUserName", Connection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@UserName", UserName);

                try
                {
                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            isFound = true;

                            UserID = (int)Reader["UserID"];
                            PasswordHash = (string)Reader["PasswordHash"];
                            Note = (string)Reader["Note"];
                            IsAdmin = (bool)Reader["IsAdmin"];
                          
                        }
                        else
                        {
                            isFound = false;
                        }

                    }

                }
                catch (Exception ex)
                {

                    throw new Exception("An error occurred while Get user By UserName.", ex);

                }

                return isFound;
            }
        }

        public static int AddNewUser(string UserName, string PasswordHash, string Note, bool IsAdmin)

        {
            int NewUserID = -1;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand Command = new SqlCommand("SP_AddNewUser", Connection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                SqlParameter outputIdParam = new SqlParameter("@NewUserID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                Command.Parameters.Add(outputIdParam);
                Command.Parameters.AddWithValue("@UserName", UserName);
                Command.Parameters.AddWithValue("@PasswordHash", PasswordHash);
                Command.Parameters.AddWithValue("@Note", Note);
                Command.Parameters.AddWithValue("@IsAdmin", IsAdmin);

                try
                {

                    Connection.Open();
                    Command.ExecuteNonQuery();
                    NewUserID = (int)outputIdParam.Value;

                }
                catch (Exception ex)
                {

                    throw new Exception("An error occurred while adding a new user.", ex);

                }
                return NewUserID;
            }

        }

        public static bool UpdateUser(int UserID, string UserName, string PasswordHash, string Note, bool IsAdmin)
        {
            int RowsEffect = 0;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand Command = new SqlCommand("SP_UpdateUser", Connection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@UserID", UserID);
                Command.Parameters.AddWithValue("@UserName", UserName);
                Command.Parameters.AddWithValue("@PasswordHash", PasswordHash);
                Command.Parameters.AddWithValue("@Note", Note);
                Command.Parameters.AddWithValue("@IsAdmin", IsAdmin);

                try
                {
                    Connection.Open();

                    RowsEffect = Command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    throw new Exception("An error occurred while Update a user.", ex);

                }
                return (RowsEffect > 0);

            }


        }

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand Command = new SqlCommand("SP_GetAllUsers", Connection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                try
                {
                    Connection.Open();
                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);
                        }

                    }

                }
                catch (Exception ex)
                {

                    throw new Exception("An error occurred while Get All user.", ex);

                }
                return dt;

            }

        }

        public static bool DeleteUserByID(int UserID)
        {

            int RowEffect = 0;
            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand Command = new SqlCommand("SP_DeleteUserByID", Connection))

            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@UserID", UserID);


                try
                {

                    Connection.Open();
                    RowEffect = Command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    throw new Exception("An error occurred while Delete a user.", ex);

                }
                return (RowEffect > 0);

            }

        }


        public static bool isUserExist(string UserName)
        {
            bool isFound = false;
            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString))
           
            using (SqlCommand Command = new SqlCommand("SP_isUserExist", Connection))
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@UserName", UserName);

                try
                {

                    Connection.Open();
                    SqlDataReader Reader = Command.ExecuteReader();
                    isFound = Reader.HasRows;

                }catch(Exception ex)
                {
                    throw new Exception("An error occurred while Delete a user.", ex);

                }

                return isFound;


            }


        }
    }
}
