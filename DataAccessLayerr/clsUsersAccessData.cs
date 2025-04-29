using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static int AddNewUser(int UserID,  int PersonID,  string UserName,  string Password,
            int Permissoins,  int JopID,  int BranchID,  bool IsActive)
        {


            //this function will return the new User id if succeeded and -1 if not.
            int UserId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (PersonID, UserName, Password, Permissoins, JopID,BranchID,Status)
                             VALUES (@PersonID, @UserName, @Password, @Permissoins, @JopID,@BranchID,@IsActive);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@JopID", JopID);
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

            string query = @"SELECT U.UserID ,U.PersonID ,U.BranchID ,U.JobID , FullName = P.FName + ' ' + P.MName + ' ' + P.LName 
                        From Users U INNER join  Branches B ON U.BranchID = B.BranchID  
                        INNER join Person P ON  U.PersonID =P.PersonID INNER JOIN Jobs J ON U.JobID = J.JobID ";


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

        public static bool ChangeUserPassword(int UserID,string NewUserPassword)
        {

            bool isChanged = false;

            string Query = @"Update Users set Password =@NewUserPassword Where UserID =@UserID ";
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", NewUserPassword);

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



    }
}
