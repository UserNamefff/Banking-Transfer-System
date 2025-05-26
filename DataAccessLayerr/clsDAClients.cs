using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr
{
    public class clsDAClients
    {
    
        public static bool GetClientInfoByClientID(int ClientID, ref int PersonID,ref string  TypeClient)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;



                    TypeClient = (string)reader["TypeClient"];
                    //ClientID = (int)reader["ClientID"];
                    PersonID = (int)reader["PersonID"];
                    

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

        public static bool GetClientInfoByPersonID(int PersonID , ref int ClientID, ref string TypeClient)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Clients WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;



                    TypeClient = (string)reader["TypeClient"];
                    //ClientID = (int)reader["ClientID"];
                    ClientID = (int)reader["ClientID"];


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


        public static int AddNewClient(int PersonID, string TypeClient)
        {
            //this function will return the new Client id if succeeded and -1 if not.
            string ClientNumbr = "";
            int Clientid = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Clients  (PersonID, TypeClient)
                              VALUES (@PersonID, @TypeClient ); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TypeClient", TypeClient);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedClientID))
                {
                    ClientNumbr = result.ToString();
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
            // return ClientNumbr; //string
        }

        public static bool UpdateClient(int ClientID, int PersonID, string TypeClient)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //ClientID, ,,,
            string query = @"Update  Clients  
                            set TypeClient = @TypeClient, 
                                PersonID = @PersonID, 
                                ClientID = @ClientID
                                where ClientID = @ClientID ";



            SqlCommand command = new SqlCommand(query, connection);

            //int ClientID,int ,string 
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@TypeClient", TypeClient);
            //command.Parameters.AddWithValue("@Client_type", Client_type);
            command.Parameters.AddWithValue("@PersonID", PersonID);
           



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


            

            string query = @"SELECT Clients.ClientID, Clients.TypeClient, Persons.FirstName, Persons.LastName, Accounts.AccountNumber
FROM     Clients INNER JOIN
                  Accounts ON Clients.ClientID = Accounts.ClientID INNER JOIN
                  Persons ON Clients.PersonID = Persons.PersonID";

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


        public static bool DeleteClientByPersonID(int PerosnID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection("");

            string query = @"Delete Clients 
                                where PerosnID = @PerosnID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PerosnID", PerosnID);

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


        public static bool IsClientExist(int ClientID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Clients WHERE ClientNumber = @ClientNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientNumber", ClientID);

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
