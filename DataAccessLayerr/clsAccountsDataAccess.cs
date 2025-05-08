using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Principal;

namespace DataAccessLayerr
{
   public class clsAccountsDataAccess
    {
        //
        //
        public static bool GetAccountInfoByAccountNumber(string AccountNumber, ref int AccountID, ref int ClientID ,ref int Account_type,ref int CurrenryID, ref string PinCode, ref double Balence,ref int CreatedByUser, ref DateTime Created_Date)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Accounts WHERE AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    AccountID = (int)reader["AccountID"];
                    PinCode = (string)reader["PinCode"];
                    ClientID = (int)reader["ClientID"];
                    Account_type = (int)reader["Account_type"];
                    Balence = (double)reader["Balence"];
                    CurrenryID = (int)reader["CurrenryID"];
                    CreatedByUser = (int)reader["CreatedByUser"];
                    Created_Date = (DateTime)reader["Created_Date"];
                  


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
        public static bool GetAccountInfoByAccountID( int AccountID, ref string AccountNumber, ref int ClientID, ref int Account_type,ref int CurrenryID, ref string PinCode, ref double Balence,ref int CreatedByUser, ref DateTime Created_Date)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Accounts WHERE AccountID = @AccountID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    AccountNumber = (string)reader["AccountNumber"];
                    PinCode = (string)reader["PinCode"]; 
                    ClientID = (int)reader["ClientID"];
                    Account_type = (int)reader["Account_type"];
                    Balence = (double)reader["Balence"];
                    CurrenryID = (int)reader["CurrenryID"];
                    CreatedByUser = (int)reader["CreatedByUser"];
                    Created_Date = (DateTime)reader["Created_Date"];
                  


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
        public static int AddNewAccount(int ClientID, string AccountNumber,  int Account_type,  int CurrenryID,  string PinCode,  double Balence, int CreatedByUser,  DateTime Created_Date)
        {
            //this function will return the new Account id if succeeded and -1 if not.
            string AccountNumbr = "";
             int Accountid = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            //string query = @"INSERT INTO Accounts (ClientID, AccountNumber,Account_type,CurrenryID,Balence,CreatedByUser,Created_Date) Values 
            //                                (@ClientID, @AccountNumber,@Account_type,@CurrenryID,@Balence,@CreatedByUser,@Created_Date); ";

            string query = @"INSERT INTO Accounts  (AccountNumber,Account_type,CurrencyID  ,ClientID,PinCode ,Balence ,Created_Date  ,CreatedByUser)
                              VALUES (@AccountNumber ,@Account_type ,@CurrencyID ,@ClientID,@PinCode,@Balence ,@Created_Date ,@CreatedByUser ); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Account_type", Account_type);
            command.Parameters.AddWithValue("@CurrenryID", CurrenryID);
            command.Parameters.AddWithValue("@Balence", Balence);
            command.Parameters.AddWithValue("@CreatedByUser", CreatedByUser);
            command.Parameters.AddWithValue("@Created_Date", Created_Date);
            
            



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString() , out int insertedAccountID))
                {
                    AccountNumbr = result.ToString();
                    Accountid = insertedAccountID;
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

            return Accountid;
           // return AccountNumbr; //string
        }
        public static bool UpdateAccount(int AccountID,int ClientID, string AccountNumber, int Account_type, int CurrenryID,  string PinCode, double Balence, int CreatedByUser,  DateTime Created_Date)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //ClientID, ,,,
            string query = @"Update  Accounts  
                            set Account_type = @Account_type, 
                                AccountNumber = @AccountNumber, 
                                Balence = @Balence,CurrenryID = @CurrenryID, ClientID= @ClientID,
                                CreatedByUser=@CreatedByUser,
                                Created_Date =@Created_Date, PinCode=@PinCode

                                where AccountID = @AccountID ";



            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountID", AccountID);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Documente_Type", Account_type);
            command.Parameters.AddWithValue("@CurrenryID", CurrenryID);
            command.Parameters.AddWithValue("@Balence", Balence);
            command.Parameters.AddWithValue("@CreatedByUser", CreatedByUser);
            command.Parameters.AddWithValue("@Created_Date", Created_Date);



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
        public static DataTable GetAllAccounts()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Accounts";

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
        public static bool DeleteAccount(int AccountID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection("");

            string query = @"Delete Accounts 
                                where AccountID = @AccountID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountID", AccountID);

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
        public static bool IsAccountExist(string AccountNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Accounts WHERE AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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
        public static bool IsAccountExist(int AccountNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Accounts WHERE AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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
        public static bool Withdraw(string AccountNumber, double Balence)
        {
            int RowsAffected = 0;   
            string Query = "Update Accounts set Balence=@Balence where  AccountNumber =@AccountNumber ";

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, conn);
            command.Parameters.AddWithValue("@Balence", Balence);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                conn.Open();
                RowsAffected = command.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                conn.Close();
                return false;
            }


            return (RowsAffected >0 );
        }
        public static bool Deposite(string AccountNumber, double Balence)
        {
            return Withdraw(AccountNumber, Balence); 
        }



    }
}
