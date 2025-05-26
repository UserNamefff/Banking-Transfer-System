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
            ,ref int Permissoins ,ref int JobID,ref int BranchID,ref bool Status)
        {
            bool isFound = false;
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserID = @UserID";

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

                    JobID = (int)reader["JobID"];
                    BranchID = (int)reader["BranchID"];
                    Permissoins = (int)reader["Permissoins"];
                    Password = (string)reader["Password"];
                    UserName = (string)reader["UserName"];
                    PersonID = (int)reader["PersonID"];
                    string is_ = (string)reader["Status"];


              



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


        public static bool GetUserInfoByUserName( string UserName, ref int PersonID, ref int UserID, ref string Password
           , ref int Permissoins, ref int JobID, ref int BranchID, ref bool Status)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    JobID = reader.GetInt32(reader.GetOrdinal("JobID"));
                    BranchID = (int)reader["BranchID"];
                    Permissoins = (int)reader["Permissoins"];
                    Password = (string)reader["Password"];
                    UserName = (string)reader["UserName"];
                    PersonID = (int)reader["PersonID"];
                    //Status = (bool)reader["Status"];






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
           , ref int Permissoins, ref int JobID, ref int BranchID, ref bool Status)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserName = @UserName And Password = @Password ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    JobID = (int)reader["JobID"];
                    BranchID = (int)reader["BranchID"];
                    Permissoins = (int)reader["Permissoins"];
                    PersonID = (int)reader["PersonID"];
                    string Is = reader.GetString(reader.GetOrdinal("Status"));

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
            int Permissoins,  int JobID,  int BranchID,  bool Status)
        {


            //this function will return the new User id if succeeded and -1 if not.
            int UserId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (PersonID, UserName, Password, Permissoins, JobID,BranchID,Status)
                             VALUES (@PersonID, @UserName, @Password, @Permissoins, @JobID,@BranchID,@Status);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@JobID", JobID);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@Permissoins", Permissoins);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Status", Status);
            

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
            int Permissoins, int JobID, int BranchID, bool Status)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Users  
                            set PersonID = @PersonID, 
                                JobID = @JobID, 
                                BranchID = @BranchID, 
                                Permissoins = @Permissoins, 
                                UserName = @UserName, 
                                Password = @Password,
                                Status =@Status
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@JobID", JobID);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@Permissoins", Permissoins);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Status", Status);

           

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

            string query = @"SELECT Users.UserID, Persons.FirstName, Persons.LastName, Users.UserName, Users.Password, Users.Status, Users.Permissoins, Jobs.JobName, Branches.BranchName
                            FROM     Users INNER JOIN  Persons ON Users.PersonID = Persons.PersonID INNER JOIN
                              Jobs ON Users.JobID = Jobs.ID INNER Join  Branches ON Users.BranchID = Branches.BranchID";

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
