using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr
{
    public class clsDANonClients
    {

       
        public static bool GetNonClientInfoByID(int ID, ref string FullName,ref string PhonNumber ,ref string Gender)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM NonClients WHERE NonClientID = @NonClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NonClientID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    FullName = reader.GetString(reader.GetOrdinal("FirstName"));
                    Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    PhonNumber = reader.GetString(reader.GetOrdinal("Phone_Number"));
                    


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

        public static int AddNewNonClient( string FullName, string PhonNumber, string Gender)
        {
            //this function will return the new NonClient id if succeeded and -1 if not.
            int NonClientID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO NonClients (FirstName,  Phone_Number)
                             VALUES (@FirstName,  @Phone_Number);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FullName);
            
            
            //command.Parameters.AddWithValue("@Gender", Gender);

            if (PhonNumber != "" && PhonNumber != null)
                
                command.Parameters.AddWithValue("@Phone_Number", PhonNumber);
            else
                command.Parameters.AddWithValue("@Phone_Number", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    NonClientID = insertedID;
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


            return NonClientID;
        }

        public static bool UpdateNonClient(int ID, string FullName, string PhonNumber, string Gender)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  NonClients  
                            set FullName = @FullName, 
                                PhonNumber = @PhonNumber, 
                                Gender =@Gender
                                where NonClientID = @NonClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NonClientID", ID);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@PhonNumber", PhonNumber);
            command.Parameters.AddWithValue("@Gender", Gender);

            if (PhonNumber != "" && PhonNumber != null)

                command.Parameters.AddWithValue("@PhonNumber", PhonNumber);
            else
                command.Parameters.AddWithValue("@PhonNumber", System.DBNull.Value);

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

        public static DataTable GetAllNonClients()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM NonClients";

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

        public static bool DeleteNonClient(int NonClientID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete NonClients 
                                where NonClientID = @NonClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NonClientID", NonClientID);

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

        public static bool IsNonClientExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM NonClients WHERE NonClientID = @NonClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NonClientID", ID);

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
