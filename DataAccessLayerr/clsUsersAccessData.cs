using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace DataAccessLayerr
{
    public class clsUsersAccessData
    {

        public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string UserName,ref string Password
            ,ref int Permissoins ,ref int JopID,ref int BranchID,ref bool IsActive)
        {
            bool isFound = false;
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserID = @UsertID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    JopID = (int)reader["JopID"];
                    BranchID = (int)reader["BranchID"];
                    Permissoins = (int)reader["Permissoins"];
                    Password = (string)reader["Password"];
                    UserName = (string)reader["UserName"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];


              



                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool GetUserInfoByUserID( string UserName, ref int PersonID, ref int UserID, ref string Password
           , ref int Permissoins, ref int JopID, ref int BranchID, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserID = @UsertID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    JopID = (int)reader["JopID"];
                    BranchID = (int)reader["BranchID"];
                    Permissoins = (int)reader["Permissoins"];
                    Password = (string)reader["Password"];
                    UserName = (string)reader["UserName"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];






                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool GetUserInfoByUserNameAndPassword(string UserName, string Password, ref int PersonID, ref int UserID
           , ref int Permissoins, ref int JopID, ref int BranchID, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserID = @UsertID And Password = @Password ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", Password);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    JopID = (int)reader["JopID"];
                    BranchID = (int)reader["BranchID"];
                    Permissoins = (int)reader["Permissoins"];
                    Password = (string)reader["Password"];
                    UserName = (string)reader["UserName"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewUser(  int PersonID,  string UserName,  string Password,
            int Permissoins,  int JobID,  int BranchID,  bool IsActive)
        {


            //this function will return the new User id if succeeded and -1 if not.
            int UserId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (PersonID, UserName, Password, Permissoins, JobID,BranchID,Status)
                             VALUES (@PersonID, @UserName, @Password, @Permissoins, @JobID,@BranchID,@IsActive);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@JobID", JobID);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@Permissoins", Permissoins);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserId = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return UserId;
        }

        public static bool UpdateUser(int  UserID, int PersonID, string UserName, string Password, 
            int Permissoins, int JopID, int BranchID, bool IsActive)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Users  
                            set PersonID = @PersonID, 
                                JopID = @JopID, 
                                BranchID = @BranchID, 
                                Permissoins = @Permissoins, 
                                UserName = @UserName, 
                                Password = @Password,
                                Status =@IsActive
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@JopID", JopID);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@Permissoins", Permissoins);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Status", IsActive);

           

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        
        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            //string query = @"SELECT U.UserID ,U.PersonID ,U.BranchID ,U.JobID , FullName = P.FirstName + ' ' + P.MidName + ' ' + P.LastName 
            //            From Users U INNER join  Branches B ON U.BranchID = B.BranchID  
            //            INNER join Persons P ON  U.PersonID =P.PersonID INNER JOIN Jobs J ON U.JobID = J.JobID ";

            string query = @"SELECT *FROM Users";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static bool ChangeUserName(int UserID,string UserName)
        {
            return false;
        }

        public static bool ChangeUserPassword(int UserID,string UserName,string NewUserPassword)
        {

            bool isChanged = false;

            string Query = @"Update Users set Password =@NewUserPassword,UserName=@UserName Where UserID =@UserID ";
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", NewUserPassword);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                isChanged = (command.ExecuteNonQuery() > 0) ? true : false;

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isChanged = false;
            }

            finally
            {
                connection.Close();
            }

            return isChanged;

        }

        public static bool DeleteUser(int UserID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Users 
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

        public static bool IsUserExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Found=1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsUserExistByPersonID (int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Found=1 FROM Users WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static int RegisterLoginLogout(int UserID, DateTime LoginLogoutDate, TimeSpan Time)
        {
            //this function will return the new User id if succeeded and -1 if not.
            int RegisterID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (UserID, LoginLogoutDate, LoginTime)
                             VALUES (@UserID, @LoginLogoutDate, @LoginTime);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LoginLogoutDate", LoginLogoutDate);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@LoginTime", Time);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    RegisterID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return RegisterID;
        }


        public static bool UpdateLoguotTime(int UserID ,TimeSpan LogoutTime)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  RegisterUsers  
                            set LogoutTime = @LogoutTime, 
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@LogoutTime", LogoutTime);
           



            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllRegisterLoginLogout()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"SELECT *FROM RegisterUsers";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }


    }
}
