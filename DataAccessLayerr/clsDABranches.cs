using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace DataAccessLayerr
{
    public class clsDABranches
    {
        public static bool GetBranchInfoByBranchID(int BranchID, ref int AddressBranch, ref string BranchName,ref double Branch_Balence, ref DateTime date)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Branches WHERE BranchID = @BranchID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BranchID", BranchID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    AddressBranch = (int)reader["AddressBranch"];
                    BranchID = (int)reader["BranchID"];
                    BranchName = (string)reader["BranchName"];
                    Branch_Balence = (double)reader["Branch_Balence"];
                   // date = (DateTime)reader["date"];


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
        public static bool GetBranchInfoByBranchName(string BranchName, ref int AddressBranch, ref int BranchID , ref double Branch_Balence, ref DateTime date)
        { 
            bool isFound = false;
            

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT  *FROM Branches WHERE BranchName =@BranchName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BranchName", BranchName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    //PhonNumber = (string)reader["PhonNumber"];
                    AddressBranch = reader.GetInt32(reader.GetOrdinal("AddressBranch"));
                    BranchID = reader.GetInt32(reader.GetOrdinal("BranchID"));
                    Branch_Balence = Convert.ToDouble(reader.GetOrdinal("Branch_Balence"));

                    //date = reader.GetDateTime(reader.GetOrdinal("date"));


                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static int AddNewBranch(  int CityID,  string BranchName, double BranchBalence , DateTime date )
        {
            //this function will return the new Branch id if succeeded and -1 if not.

            int Branchid = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Branches (CityID, BranchName ,BranchBalence,date);SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CityID", CityID);
            command.Parameters.AddWithValue("@BranchName", BranchName);
            command.Parameters.AddWithValue("@BranchBalence", BranchBalence);
            command.Parameters.AddWithValue("@date", date);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedBranchID))
                {
                    Branchid = insertedBranchID;
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

            return Branchid;

        }
        public static bool UpdateBranch(int BranchID, int CityID, string BranchName, double BranchBalence)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Branches  
                            set BranchName = @BranchName, 
                                CityID = @CityID ,
                                BranchBalence = @BranchBalence
                                where BranchID = @BranchID ";



            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@CityID", CityID);
            command.Parameters.AddWithValue("@BranchName", BranchName);
            command.Parameters.AddWithValue("@BranchBalence", BranchBalence);



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
        public static DataTable GetAllBranches()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Branches";

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
        public static bool DeleteBranch(int BranchID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Branches
                                where BranchID = @BranchID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BranchID", BranchID);
            
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
        public static bool IsBranchExist(int BranchID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Branches WHERE BranchID = @BranchID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BranchID", BranchID);

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
        public static bool IsBranchExistByBranchName(string BranchName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Branches WHERE BranchName = @BranchName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BranchName", BranchName);

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
        public static bool UpdateBalenceOFBranch(int  BranchID, double NewBalence)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Branches  
                               set BranchBalence = @BranchBalence
                               where BranchID = @BranchID ";



            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@BranchBalence", NewBalence);



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

            return rowsAffected > 0;
        }

    }
}
