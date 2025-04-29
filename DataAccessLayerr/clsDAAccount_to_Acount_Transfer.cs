using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr
{
    class clsDAAccount_to_Acount_Transfer
    {
        public static bool GetAccountToAccountTransferInfoByID(int ID, ref int TransactionID, ref int ClientSenderID, ref int ClientRecierveID, ref int Resource_Branch_ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM AccountToAccountTransfer WHERE AccountToAccountTransferID = @AccountToAccountTransferID";

            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@AccountToAccountTransferID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    //The record was found
                    isFound = true;
                  
                    TransactionID = (int)reader     ["TransactionID"     ];
                    ClientSenderID = (int)reader    ["ClientSenderID"    ];
                    ClientRecierveID = (int)reader  ["ClientRecierveID"  ];
                    Resource_Branch_ID = (int)reader["Resource_Branch_ID"];

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

        public static int AddNewAccountToAccountTransfer(int TransationID, int ClientID, int ReceiverID, ref int Targeted_Branch_ID)
        {
            //this function will return the new Transfer id if succeeded and -1 if not.

            int AccountToAccountTransferId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO AccountToAccountTransfers (TransationID, ClientID ,ReceiverID,Targeted_Branch_ID)
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


                if (result != null && int.TryParse(result.ToString(), out int insertedAccountToAccountTransferID))
                {
                    AccountToAccountTransferId = insertedAccountToAccountTransferID;
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

            return AccountToAccountTransferId;

        }

        public static bool UpdateAAccountToAccountTransfer(int ID, int TransationID, int ClientID, int ReceiverID, ref int Targeted_Branch_ID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  AccountToAccountTransfers  
                                set TransationID = @TransationID, 
                                ClientID = @ClientID ,
                                ReceiverID = @ReceiverID,
                                Targeted_Branch_ID = @Targeted_Branch_ID,
                                where AccountToAccountTransferID = @AccountToAccountTransferID ";
            //TransationID,  ,ReceiverID,Targeted_Branch_ID


            SqlCommand command = new SqlCommand(query, connection);

             command.Parameters.AddWithValue("@AccountToAccountTransferID", ID);
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
        
        public static DataTable GetAllAAccountToAccountTransfers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM AccountToAccountTransfers";
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

        public static bool DeleteAccountToAccountTransfer(int AccountToAccountTransferID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete AccountToAccountTransfers
                                where AccountToAccountTransferID = @AccountToAccountTransferID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountToAccountTransferID", AccountToAccountTransferID);

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

        public static bool IsTransferExist(int AccountToAccountTransferID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM AccountToAccountTransfers WHERE AccountToAccountTransferID = @AccountToAccountTransferID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountToAccountTransferID", AccountToAccountTransferID);

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
