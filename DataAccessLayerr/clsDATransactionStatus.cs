using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr
{
    public class clsDATransactionStatus
    {

        public static bool GetTransactionStatusByStatusName(string StatusName,ref int ID )
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT  *FROM Transaction_Status Where StatusName = @StatusName ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@StatusName", StatusName);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    if (reader.HasRows)
                    {
                        isFound = true;
                        ID = reader.GetInt32(reader.GetOrdinal("StatusID"));
                    }
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

           return isFound;
        }

        public static DataTable GetAllTransactionStatus()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Transaction_Status";

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
