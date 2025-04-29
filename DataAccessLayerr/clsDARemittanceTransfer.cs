using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr
{
    public class clsDARemittanceTransfer
    {
        
        public static bool GetRemittancingTransfer (int ID , ref int TransferID , ref string PersonalCardImagePath , ref DateTime RemittanceDate)
        {
            bool isFound = false;

            string query = "Select * FROM RemittancingTransfers WHERE RemittancingTransferID =@RemittancingTransferID";
            SqlConnection con =  new SqlConnection (clsDataAccessSettings.ConnectionString);

            SqlCommand cmd = new SqlCommand (query, con);
            cmd.Parameters.AddWithValue("@RemittancingTransferID", ID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    TransferID = (int)reader["TransferID"];
                    PersonalCardImagePath = (string)reader["PersonalCardImagePath"];
                    RemittanceDate = (DateTime)reader["RemittanceDate"];

                }

            }
            catch (Exception ex)
            {
                isFound = false;
            }

            finally
            {
                con.Close();
            }

            return isFound;
        }

        public static int AddNewRemittancingTransfer(  int TransferID,  string PersonalCardImagePath,  DateTime RemittanceDate)
        {
            //this function will return the new Transfer id if succeeded and -1 if not.

            int RemittancingTransferID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO AccountToAccountTransfers (TransferID, PersonalCardImagePath ,RemittanceDate)
                                    Values(@TransferID, @PersonalCardImagePath ,@RemittanceDate);SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            //int ,ref int ClientID ,ref int ReceiverID,ref int Targeted_Branch_ID
            command.Parameters.AddWithValue("@TransferID", TransferID);
            command.Parameters.AddWithValue("@PersonalCardImagePath", PersonalCardImagePath);
            command.Parameters.AddWithValue("@Date", RemittanceDate);
            



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedRemittancingTransferID))
                {
                    RemittancingTransferID = insertedRemittancingTransferID;
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

            return RemittancingTransferID;

        }

        public static bool UpdateAAccountToAccountTransfer(int ID, int TransferID, string PersonalCardImagePath, DateTime RemittanceDate)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  RemittancingTransfers  
                                set TransferID = @TransferID, 
                                PersonalCardImagePath = @PersonalCardImagePath ,
                                RemittanceDate = @RemittanceDate
                                where RemittancingTransferID = @RemittancingTransferID ";
            
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransferID", TransferID);
            command.Parameters.AddWithValue("@PersonalCardImagePath", PersonalCardImagePath);
            command.Parameters.AddWithValue("@RemittanceDate", RemittanceDate);


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

        public static DataTable GetAllRemittancingTransfers()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //int TransferID,  string , DateTime 
            //string query = " SELECT  Ttype.Name ,T.Amount , FullName = 'NonClient.FName ' + ' NonClient.LName' , Reciever Transactions T  FROM RemittancingTransfers  ";

            string query = @"SELECT 
                rt.RemittanceID, rt.RemittanceDate,t.TransactionAmount,currecy.CurrencyName,nc.SenderName,
                nc.SenderPhone , nc.ReceiverName , nc.ReceiverCountry , ts.StatusName , ts.StatusDescription
                ,rt.PersonalCardImagePath 
                FROM RemittanceTransactions rt
                INNER JOIN transactions t ON rt.TransferID = t.TransferID
                INNER JOIN Nonclient nc ON t.nonclient_id = nc.nonclient_id
                INNER JOIN Currency currency ON t.CurrencyID = currency.CurrencyID
                INNER JOIN TransactionStatus ts ON t.status_id = ts.status_id ";

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

        public static bool DeleteRemittancingTransfers(int RemittanceID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete RemittancingTransfers
                                where RemittanceID = @RemittanceID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RemittanceID", RemittanceID);

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

        public static bool IsTransferExist(int RemittanceID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM RemittancingTransfers WHERE RemittanceID = @RemittanceID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RemittanceID", RemittanceID);

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
