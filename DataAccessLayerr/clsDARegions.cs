using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr
{
   public  class clsDARegions
   {


        public static bool GetRegionInfoByRegionID(int RegionID, ref int CityID, ref string RegionName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Regions WHERE RegionID = @RegionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RegionID", RegionID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    CityID = (int)reader["CityID"];
                    //CityID = (int)reader["CityID"];
                    RegionName = (string)reader["RegionName"];


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


        public static bool GetRegionInfoByRegionID(string RegionName, ref int CityID, ref int RegionID )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Regions WHERE RegionID = @RegionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RegionID", RegionID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    CityID = (int)reader["CityID"];
                    //CityID = (int)reader["CityID"];
                    RegionName = (string)reader["RegionName"];


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


        public static int AddNewRegion( int CityID,  string RegionName)
        {
            //this function will return the new City id if succeeded and -1 if not.

            int Cityid = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Citys (CityID, CityName)
                             Values(@CityID, @CityName); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@CityID", CityID);
            //command.Parameters.AddWithValue("@CityID", CityID);
            command.Parameters.AddWithValue("@RegionName", RegionName);


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

        public static bool UpdateRegion(int RegionID, int CityID, string RegionName)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Regions  
                            set RegionName = @RegionName, 
                                CityID = @CityID 
                                where RegionID = @RegionID ";



            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RegionID",  RegionID);
            command.Parameters.AddWithValue("@CityID", CityID);
            command.Parameters.AddWithValue("@RegionName", RegionName);



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

        public static DataTable GetAllRegions()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT  R.RegionID,R.RegionName ,C.CityName FROM Regions R INNer Join Cities C ON R.CityID = C.CityID ";

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

        public static bool DeleteRegion(int RegionID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Regions
                                where RegionID = @RegionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RegionID", RegionID);

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

        public static bool IsRegionExist(int RegionID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Regions WHERE RegionID = @RegionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RegionID", RegionID);

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

        public static bool IsRegionExistByRegionName(string RegionName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Regions WHERE RegionName = @RegionName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RegionName", RegionName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (SqlException ex)
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


        public static DataTable GetAllRegionss()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select *From Regions";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

               
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                
                reader.Close();

            }
            catch (SqlException ex)
            {
               dt = null;
            }

            finally
            {
                conn.Close();
            }
            return dt;
        }


   }
}
