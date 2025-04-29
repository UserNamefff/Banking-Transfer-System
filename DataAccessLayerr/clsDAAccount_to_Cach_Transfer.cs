using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr
{
   public class clsDAAccountToCachTransfer
    {

        public static bool GetAccountToCachTransferInfoByID(int ID, ref int TransactionID, ref int ClientID, ref int ReceiverID, ref int Targeted_Branch_ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM AccountToCachTransfer WHERE AccountToCachTransferID = @AccountToCachTransferID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountToCachTransferID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    //The record was found
                    isFound = true;

                    TransactionID = (int)reader["AccountToCachTransferID"];
                    ClientID = (int)reader["ClientID"];
                    ReceiverID = (int)reader["ReceiverID"];
                    Targeted_Branch_ID = (int)reader["Targeted_Branch_ID"];

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

        public static int AddNewAAccountToCachTransfer(int TransationID, int ClientID, int ReceiverID, ref int Targeted_Branch_ID)
        {
            //this function will return the new Transfer id if succeeded and -1 if not.

            int AccountToCachTransferId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO AccountToCachTransfers (TransationID, ClientID ,ReceiverID,Targeted_Branch_ID)
                                    Values(@TransationID, @ClientID ,@ReceiverID,@Targeted_Branch_ID);SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            //int ,ref int ClientID ,ref int ReceiverID,ref int Targeted_Branch_ID
            command.Parameters.AddWithValue("@TransationID", TransationID);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@ReceiverID", ReceiverID);
            command.Parameters.AddWithValue("@Targeted_Branch_ID", Targeted_Branch_ID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedAccountToCachTransferID))
                {
                    AccountToCachTransferId = insertedAccountToCachTransferID;
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

            return AccountToCachTransferId;

        }

        public static bool UpdateAAccountToCachTransfer(int ID,int TransationID, int ClientID, int ReceiverID, ref int Targeted_Branch_ID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  AccountToCachTransfers  
                                set TransationID = @TransationID, 
                                ClientID = @ClientID ,
                                ReceiverID = @ReceiverID,
                                Targeted_Branch_ID = @Targeted_Branch_ID,
                                where AccountToCachTransferID = @AccountToCachTransferID ";
             //TransationID,  ,ReceiverID,Targeted_Branch_ID


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountToCachTransferID", ID);
            command.Parameters.AddWithValue("@TransationID", TransationID);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@ReceiverID", ReceiverID);
            command.Parameters.AddWithValue("@Targeted_Branch_ID", Targeted_Branch_ID);

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


        public static DataTable GetAllAAccountToCachTransfers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = "SELECT * FROM AccountToCachTransfers";
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

        public static bool DeleteAccountToCachTransfer(int AccountToCachTransferID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete AccountToCachTransfers
                                where AccountToCachTransferID = @AccountToCachTransferID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountToCachTransferID", AccountToCachTransferID);

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

        public static bool IsAccountToCachTransferExist(int AccountToCachTransferID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM AccountToCachTransfers WHERE AccountToCachTransferID = @AccountToCachTransferID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountToCachTransferID", AccountToCachTransferID);

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
