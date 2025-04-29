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
   public class clsClientsDataAccess
    {

        public static bool GetClientInfoByAccountNumber(string AccountNumber ,ref int PersonID ,ref int Account_type,ref int CurrenryID ,ref double Balence)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Clients WHERE AccountNumber = @AccountNumber";

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

                    PersonID = (int)reader["PersonID"];
                    Account_type = (int)reader["Account_type"];
                    Balence = (double)reader["Balence"];
                    CurrenryID = (int)reader["CurrenryID"];


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

        public static int AddNewClient(int PersonID, string AccountNumber,  int Account_type,  int CurrenryID,  double Balence)
        {
            //this function will return the new Client id if succeeded and -1 if not.
            string AccountNumbr = "";
             int Clientid = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Clients (PersonID, AccountNumber,Account_type,CurrenryID,Balence);SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Documente_Type", Account_type);
            command.Parameters.AddWithValue("@CurrenryID", CurrenryID);
            command.Parameters.AddWithValue("@Balence", Balence);
            
            



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString() , out int insertedClientID))
                {
                    AccountNumbr = result.ToString();
                    Clientid = insertedClientID;
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

            return Clientid;
           // return AccountNumbr; //string
        }

        public static bool UpdateClient(int ID, string AccountNumber, int Account_type, int CurrenryID, double Balence)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //PersonID, ,,,
            string query = @"Update  Clients  
                            set Account_type = @Account_type, 
                                AccountNumber = @AccountNumber, 
                                Balence = @Balence, 
                                where ClientID = @ClientID ";

          

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Documente_Type", Account_type);
            command.Parameters.AddWithValue("@CurrenryID", CurrenryID);
            command.Parameters.AddWithValue("@Balence", Balence);



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

        public static DataTable GetAllClients()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Clients";

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

        public static bool DeleteClient(int ClientID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection("");

            string query = @"Delete Clients 
                                where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static bool IsClientExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ID);

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
            string Query = "Update Clients set Balence=@Balence where  AccountNumber =@AccountNumber ";

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
