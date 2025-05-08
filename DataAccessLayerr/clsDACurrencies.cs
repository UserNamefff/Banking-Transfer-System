using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr
{
    public class clsDACurrencies
    {
        public static bool GetCurrencyInfoByID(int CurrencyID, ref string CurrencyName,ref string CurrencyCode, ref double Rate, ref int CountryID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Currencys WHERE CurrencyID = @CurrencyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    CurrencyCode = (string)reader["CurrencyCode"];
                    Rate = (double)reader["Rate"];
                    CountryID   = (int)reader["CountryID"];

                    
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

        public static bool GetCurrencyInfoByID(string CurrencyCode, ref string CurrencyName, ref int CurrencyID , ref double Rate, ref int CountryID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Currencies WHERE CurrencyCode = @CurrencyCode";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    CurrencyName =  reader.GetString(reader.GetOrdinal("CurrencyName"));
                    CurrencyID =  reader.GetInt32(reader.GetOrdinal("CurrencyID"));
                    Rate =Convert.ToDouble( reader.GetOrdinal("Rate"));
                    CountryID = reader.GetInt32(reader.GetOrdinal("CountryID"));
                    
                    



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


        public static int AddNewCurrency(string CurrencyCode,  double Rate,string CurrencyName , int CountryID)
        {
            //this function will return the new Currency id if succeeded and -1 if not.
            int CurrencyID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Currencies (CurrencyName,CountryID, Rate, CountryID,CurrencyCode)
                             VALUES (@CurrencyName,@CountryID, @Rate, @CountryID,@CurrencyCode);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyName", CurrencyName);
            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);
            command.Parameters.AddWithValue("@Rate", Rate);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    CurrencyID = insertedID;
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


            return CurrencyID;
        }

        public static bool UpdateCurrency(int CurrencyID, string CurrencyCode, double Rate, string CurrencyName, int CountryID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            
            string query = @"Update  Currencies 
                            set CurrencyCode = @CurrencyCode, 
                                CurrencyName = @CurrencyName, 
                                CountryID = @CountryID, 
                                Rate = @Rate 
                                where CurrencyID = @CurrencyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            command.Parameters.AddWithValue("@CurrencyName", CurrencyName);
            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);
            command.Parameters.AddWithValue("@Rate", Rate);
            command.Parameters.AddWithValue("@CountryID", CountryID);

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

        public static bool UpdateCurrencyRateByID(int CurrencyID, double Rate)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"Update  Currencies 
                                set Rate = @Rate 
                                where CurrencyID = @CurrencyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            command.Parameters.AddWithValue("@Rate", Rate);
            

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

        public static DataTable GetAllCurrencies()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Currencies ";

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
        
        public static bool DeleteCurrency(int CurrencyID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Currencies 
                                where CurrencyID = @CurrencyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

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

        public static bool IsCurrencyExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Currencies WHERE CurrencyID = @CurrencyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyID", ID);

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
