﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace DataAccessLayerr
{
    public class clsDATransactions
    {

        private static void IsRecordNull(ref int Record)
        {//,ref int ClientRecierver,ref int SenderClientSender
            
           if(Record == null)
           {
               Record = 0;
           }

        }

        public static bool GetTransactionInfoByTransactionID(int TransactionNumber,ref int TransactionID, ref int SenderID, ref int RecierverID,ref int SourceBranchID,
            ref int TargeteBranchID, ref int  Transaction_Status_ID, ref int Transaction_type
            , ref double FeeAmount , ref int CurrencyID , ref double TransferAmount , ref DateTime Date_Transaction,ref bool isSenderClient, ref bool isRecierverClient, ref string Description,ref int CreatedBy)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = "SELECT * FROM Transactions WHERE TransactionNumber = @TransactionNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransactionNumber", TransactionNumber);

            try
            {
                connection.Open();                            
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    //The record was found
                    isFound = true;
                    
                    Transaction_Status_ID = (int)reader["Transaction_Status_ID"];
                    FeeAmount = Convert.ToDouble( reader["FeeAmount"]);
                    CurrencyID = (int)reader["CurrencyID"];
                    SenderID = (int)reader["SenderID"];
                    RecierverID = (int)reader["RecierverID"];
                    SourceBranchID = (int)reader["SourceBranchID"];
                    TargeteBranchID = (int)reader["TargeteBranchID"];
                    Transaction_type = (int)reader["Transaction_type"];
                    TransferAmount = Convert.ToDouble(reader["TransferAmount"]);
                    Date_Transaction = (DateTime)reader["Date_Transaction"];
                    CreatedBy = (int)reader["CreatedBy"];
                    
                    //ClientRecierverID = (int)reader["ClientRecierverID"];

                    if(reader["Description"] != DBNull.Value)
                    {
                    Description = (string)reader["Description"];

                    }
                    else
                    {
                        Description = "";
                    }


                        //  
                        IsRecordNull(ref TargeteBranchID);
                    IsRecordNull(ref SourceBranchID);
                    IsRecordNull(ref RecierverID);
                   

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
        
        public static int AddNewTransaction( int TransactionNumber,  int SenderID,  int RecierverID,  int SourceBranchID,
             int TargeteBranchID, int  Transaction_Status_ID,  int Transaction_type
            ,  double FeeAmount, int CurrencyID,  double TransferAmount,  DateTime Date_Transaction, bool isClientRecierver, bool isClientSender,
             string Description, int CreatedBy)
        {
            //this function will return the new Transaction id if succeeded and -1 if not.

            int Transactionid = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            //string query = @"INSERT INTO Transactions (TransactionNumber,SenderID,RecierverID,SourceBranchID,TargeteBranchID, Transaction_Status_ID ,TransferAmount,FeeAmount,CurrencyID,Date_Transaction,isClientRecierver,isClientSender,ClientRecierverID,ClientSenderID,Description)
            //                        Values(@TransactionNumber,@SenderID,@RecierverID,@SourceBranchID,@TargeteBranchID, @Transaction_Status_ID ,@TransferAmount,@FeeAmount,@CurrencyID,@Date_Transaction,@isClientRecierver,@isClientSender,@Description);SELECT SCOPE_IDENTITY();";

                string query = @"INSERT INTO Transactions
               (TransactionNumber
               ,SenderID
               ,RecierverID
               ,SourceBranchID
               ,TargeteBranchID
               ,Transaction_Status_ID
               ,TransferAmount
               ,FeeAmount
               ,CurrencyID
               ,Date_Transaction
               ,Transaction_type
               ,isClientRecierver
               ,isClientSender
               ,Description,CreatedBy)
         VALUES (@TransactionNumber,@SenderID,@RecierverID, @SourceBranchID,@TargeteBranchID, @Transaction_Status_ID, 
			    @TransferAmount, @FeeAmount,@CurrencyID,@Date_Transaction,@Transaction_type, 
			    @isClientRecierver, @isClientSender,@Description,@CreatedBy)";

            SqlCommand command = new SqlCommand(query, connection);

            
            IsRecordNull(ref TargeteBranchID);
            IsRecordNull(ref SenderID);
            IsRecordNull(ref RecierverID);

            //ClientRecierverID,ClientSenderID
            command.Parameters.AddWithValue("@TransactionNumber", TransactionNumber);
            command.Parameters.AddWithValue("@Transaction_Status_ID", Transaction_Status_ID);
            command.Parameters.AddWithValue("@FeeAmount", FeeAmount);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            command.Parameters.AddWithValue("@RecierverID", RecierverID);
            command.Parameters.AddWithValue("@SenderID", SenderID);
            command.Parameters.AddWithValue("@TargeteBranchID", TargeteBranchID);
            command.Parameters.AddWithValue("@SourceBranchID", SourceBranchID);
            command.Parameters.AddWithValue("@TransferAmount", TransferAmount);
            command.Parameters.AddWithValue("@Date_Transaction", Date_Transaction);
            command.Parameters.AddWithValue("@Transaction_type",  Transaction_type);
            command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            
           
            command.Parameters.AddWithValue("@isClientSender", isClientSender);
            command.Parameters.AddWithValue("@isClientRecierver", isClientRecierver);
        
            command.Parameters.AddWithValue("@Description", Description);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedTransactionID))
                {
                    Transactionid = insertedTransactionID;
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

            return Transactionid ;

        }

        public static bool UpdateTransaction(int TransactionID,  int TransactionNumber,  int SenderID,  int RecierverID,  int SourceBranchID,
             int TargeteBranchID, int  Transaction_Status_ID,  int Transaction_type
            ,  double FeeAmount, int CurrencyID,  double TransferAmount,  DateTime Date_Transaction, bool isClientRecierver, bool isClientSender,   string Description, int CreatedBy)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Transactions  
                            set TransactionNumber = @TransactionNumber, 
                                Transaction_Status_ID = @Transaction_Status_ID ,
                                TransferAmount = @TransferAmount,
                                RecierverID = @RecierverID,
                                SenderID =@SenderID,
                                TargeteBranchID=@TargeteBranchID,
                                SourceBranchID=@SourceBranchID,
                                FeeAmount = @FeeAmount,
                                CurrencyID = @CurrencyID,Transaction_type =@Transaction_type,
                                Date_Transaction = @Date_Transaction ,
                                Description = @Description , isClientSender=@isClientSender ,
                                isClientRecierver =@isClientRecierver 
                                CreatedBy = @CreatedBy
                               

                                where TransactionID = @TransactionID ";

            

            SqlCommand command = new SqlCommand(query, connection);

            
            IsRecordNull(ref TargeteBranchID);
            IsRecordNull(ref SenderID);
            IsRecordNull(ref RecierverID);

            command.Parameters.AddWithValue("@TransactionNumber", TransactionNumber);
            command.Parameters.AddWithValue("@Transaction_Status_ID", Transaction_Status_ID);
            command.Parameters.AddWithValue("@FeeAmount", FeeAmount);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            command.Parameters.AddWithValue("@RecierverID", RecierverID);
            command.Parameters.AddWithValue("@SenderID", SenderID);
            command.Parameters.AddWithValue("@TargeteBranchID", TargeteBranchID);
            command.Parameters.AddWithValue("@SourceBranchID", SourceBranchID);
            command.Parameters.AddWithValue("@TransferAmount", TransferAmount);
            command.Parameters.AddWithValue("@isClientSender", isClientSender);
            command.Parameters.AddWithValue("@isClientRecierver", isClientRecierver);
            command.Parameters.AddWithValue("@Transaction_type", Transaction_type);
            command.Parameters.AddWithValue("@CreatedBy", CreatedBy);

            command.Parameters.AddWithValue("@Date_Transaction", Date_Transaction);
            command.Parameters.AddWithValue("@Description", Description);


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


        public static bool UpdateTransactionStatus(int TransactionID,int TransactionStatusID)
        {
            int RowsAffected = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Transactions SET TransactionStatusID = @TransactionStatusID WHERE TransactionID = @TransactionID ";
            SqlCommand comm = new SqlCommand(query, conn);
            
            comm.Parameters.AddWithValue("@TransactionStatusID", TransactionStatusID);
            comm.Parameters.AddWithValue("@TransactionID", TransactionID);

            try
            {
                conn.Open();

                RowsAffected = comm.ExecuteNonQuery();

            }

            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return RowsAffected >0;
        }

        public static DataTable GetAllTransactiones()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Transactions";

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

        public static DataTable GetAllRemittancingTransfers()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //int TransferID,  string , DateTime 
            //string query = " SELECT  Ttype.Name ,T.Amount , FullName = 'NonClient.FName ' + ' NonClient.LName' , Reciever Transactions T  FROM RemittancingTransfers  ";
            /*
             
            int TransactionNumber,ref int TransactionID, ref int SenderID, ref int RecierverID,ref int SourceBranchID,
            ref int TargeteBranchID, ref int  Transaction_Status_ID 
            , ref double FeeAmount , ref int CurrencyID , ref double TransferAmount , ref DateTime Date_Transaction, ref string Description 

             */
            string query = @"SELECT 
                t.TransactionAmount,nc.SenderName,nc.SenderPhone ,
                nc.ReceiverName , currecy.CurrencyName , ts.StatusName , ts.StatusDescription
                FROM Transactions rt
                INNER JOIN transactions t ON rt.TransferID = t.TransferID
                INNER JOIN Nonclient nc ON t.nonclient_id = nc.nonclient_id
                INNER JOIN Currency currency ON t.CurrencyID = currency.CurrencyID
                INNER JOIN TransactionStatus ts ON t.status_id = ts.status_id " ;

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

        public static bool DeleteTransaction(int TransactionID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Transactions
                                where TransactionID = @TransactionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransactionID", TransactionID);

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

        public static bool IsTransactionExist(int TransactionNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Transactions WHERE TransactionNumber = @TransactionNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransactionNumber", TransactionNumber);

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

        public static bool UpdateTransactionStatus(int TransactionID,string TransactionStatus)
        {
           int RowsAffective = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Update Transactions set TransactionStatus =@TransactionStatus WHERE TransactionID = @TransactionID ";

            SqlCommand command = new SqlCommand(Query,conn);

            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            command.Parameters.AddWithValue("@TransactionStatus", TransactionStatus);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return (RowsAffective > 0);
            }
            finally
            {
                conn.Close();
               
            }


            return (RowsAffective >0);
        }


       

    }
}
