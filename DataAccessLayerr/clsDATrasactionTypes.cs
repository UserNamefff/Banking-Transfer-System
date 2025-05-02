using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr
{
   public class clsDATrasactionTypes
   {
        public static DataTable GetAllTransaction_types(bool FromORToAccount = true)
        {
            string Type = "";
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Transaction_types";
            if (FromORToAccount)
            {
                Type = "From Account";
                /* 
                     query = "SELECT * FROM Transaction_types WHere Transaction_typeName !=@Type "; 
                     Exeption Error Because Type Instead of Transaction_typeName
                */

                query = "SELECT * FROM Transaction_types WHere Transaction_typeName !=@Transaction_typeName ";
            }

            else
            {
                Type = "To Account";
                query = "SELECT * FROM Transaction_types  WHere Transaction_typeName !=@Transaction_typeName ";
            }



            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Transaction_typeName", Type);
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
