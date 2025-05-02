using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr
{
    public class clsDACities
    {

        public static bool GetCityInfoByCityID(int CityID, ref int CountryID, ref string CityName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Cities WHERE CityID = @CityID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CityID", CityID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    CountryID = (int)reader["CountryID"];
                    CityID = (int)reader["CityID"];
                    CityName = (string)reader["CityName"];
                    

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

        public static int AddNewCity( int CountryID,  string CityName)
        {
            //this function will return the new City id if succeeded and -1 if not.
         
            int Cityid = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Citys (CityID,CountryID, CityName);SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@CountryID", CountryID);
            //command.Parameters.AddWithValue("@CityID", CityID);
            command.Parameters.AddWithValue("@CityName", CityName);
            

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedCityID))
                {
                    Cityid = insertedCityID;
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

            return Cityid;
            
        }

        public static bool UpdateCity(int CityID, int CountryID,  string CityName)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = @"Update  Cities  
                            set CityName = @CityName, 
                                CountryID = @CountryID 
                                where CityID = @CityID ";



            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@CityID", CityID);
            command.Parameters.AddWithValue("@AccountNumber", CountryID);
            command.Parameters.AddWithValue("@Documente_Type", CityName);
            


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

        public static DataTable GetAllCities()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT City.CityID ,City.CityName ,C.CountryName FROM Cities City INNer Join Countries C ON City.CountryID = C.CountryID ";

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

            catch (SqlException ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static bool DeleteCity(int CityID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Cities
                                where CityID = @CityID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CityID", CityID);

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

        public static bool IsCityExist(int CityID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Cities WHERE CityID = @CityID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CityID", CityID);

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

        public static bool IsCityExistByCityName(string CityName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Cities WHERE CityName = @CityName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CityName", CityName);

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
