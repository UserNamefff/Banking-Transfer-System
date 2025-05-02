using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr
{
   public  class clsRegions
   {

        public static DataTable GetAllRegions()
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
