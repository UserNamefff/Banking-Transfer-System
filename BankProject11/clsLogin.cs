using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
namespace BankProject11
{
    class clsLogin
    {
        
        private string _UserName;
        private string _Password;
        private int Id;


        public clsLogin (int ID ,string username, string password)
        {
            this.Id = ID ;
            this._UserName = username ;
            this._Password = password ;
           
        }
       
        static SqlConnection conn;
        public static clsLogin Find(string username, string password)
        {
             string ConectionToDb = "Server =.; DataBase=BankSystem;Integrated Security=True; ";

            SqlConnection conn = new SqlConnection(ConectionToDb);

            string Query = "Select * From Users";


            

            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    int UsID = (int)reader["ID"];
                    string UsN = (string)reader["UserName"];
                    string UsPassword = (string)reader["Password"];

                    if (UsN.Trim() == username.Trim() && UsPassword.Trim() == password.Trim())
                    {
                        return new clsLogin(UsID, UsN, UsPassword);
                    }
                }
                conn.Close();
                reader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
               
            }
            return null;
        }

        public static DataTable GetAllContacts()
        {
            string ConectionToDb = "Server =.; DataBase=BankSystem;Integrated Security=True; ";

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConectionToDb);

            string query = "SELECT * FROM Contacts";

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
                connection.Close();

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
