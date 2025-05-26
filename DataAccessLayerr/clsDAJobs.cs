using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr
{
    public class clsDAJobs
    {

        public static bool GetJobInfoByID(int ID, ref string jobName)
        {
          bool isFound = false; 
         SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT *FROM Jobs Where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
           
            cmd.Parameters.AddWithValue("@ID", ID);
            
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    jobName = reader["JobName"].ToString();
                    //jobDescription = reader["JobDescription"].ToString();
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("Error fetching job information: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
            return isFound;


        }


        public static bool GetJobInfoByName(string jobName, ref int ID, ref string jobDescription)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Jobs WHERE JobName = @JobName";
            SqlCommand cmd = new SqlCommand(query, conn);
           
            cmd.Parameters.AddWithValue("@JobName", jobName);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ID =reader.GetInt32(reader.GetOrdinal( "ID"));
                    //jobDescription = reader["JobDescription"].ToString();
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("Error fetching job information: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isFound;
        }

        public static DataTable GetAllJobs()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Jobs";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("Error fetching all jobs: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
            return dt;
        }

        public static bool AddNewJob(string jobName, string jobDescription)
        {
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO Jobs (JobName) VALUES (@JobName)";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            cmd.Parameters.AddWithValue("@JobName", jobName);
            

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; // Return true if a row was inserted
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("Error adding job: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public static bool UpdateJob(int ID, string jobName)
        {
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE Jobs SET JobName = @JobName WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            cmd.Parameters.AddWithValue("@JobName", jobName);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; // Return true if a row was updated
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("Error updating job: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public static bool DeleteJob(int ID)
        {
            int rowsAffected = 0;
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE FROM Jobs WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                conn.Open();
                 rowsAffected = cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("Error deleting job: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return rowsAffected > 0; // Return true if a row was deleted 
        }

        public static bool IsJobNameExists(string jobName)
        {
            bool exists = false;
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT COUNT(*) FROM Jobs WHERE JobName = @JobName";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            cmd.Parameters.AddWithValue("@JobName", jobName);
            
            try
            {
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0; // If count is greater than 0, the job name exists
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new Exception("Error checking job name existence: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
            return exists;
        }

    }
}
