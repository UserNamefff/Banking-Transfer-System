using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DataAccessLayerr
{
   public class clsDABoxToUsers
    {

        public static bool GetBoxInfoByBoxID(int BoxID, int UserID, ref string BoxName ,ref double BoxBalence, ref double Revenues,ref string BoxType, ref DateTime Date,int CurrencyID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Boxes WHERE BoxID = @BoxID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BoxID", BoxID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    //The record was found
                    isFound = true;

                    BoxName = (string)reader["BoxName"];
                    BoxBalence = Convert.ToDouble(reader["BoxBalence"]);
                    Revenues = Convert.ToDouble(reader["Revenues"]);
                    BoxType = (string)reader["BoxType"];
                    //Date = (DateTime)reader["Date"];
                    CurrencyID = (int)reader["CurrencyID"];
                    

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (SqlException ex)
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

        public static bool GetBoxInfoByBoxName(string BoxName, int UserID, ref int BoxID , ref double BoxBalence, ref double Revenues, ref string BoxType, ref DateTime Date)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Boxes WHERE BoxName = @BoxName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BoxName", BoxName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    //The record was found
                    isFound = true;

                    BoxID = (int)reader["BoxID"];
                    BoxBalence = (double)reader["BoxBalence"];
                    Revenues = (int)reader["Revenues"];
                    BoxType = (string)reader["BoxType"];
                    Date = (DateTime)reader["Date"];


                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (SqlException ex)
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


        public static int AddNewBox( int UserID,string BoxName, double BoxBalence,  double Revenues,  string BoxType, DateTime Date,int CurrencyID = 17)
        {
            //this function will return the new Box id if succeeded and -1 if not.

            int Boxid = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [Boxes]
           ([BoxName]
           ,[BoxBalence]
           ,[UserID]
           ,[Revenues]
           ,[BoxType]
           ,[FK_CurrencyBox]
           ,[CurrencyID])
     VALUES
           (@BoxName, 
           @BoxBalence, 
           @UserID,
           @Revenues, 
           @BoxType, 
           @FK_CurrencyBox, 
           @CurrencyID);SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@BoxName", BoxName);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@BoxBalence", BoxBalence);
            command.Parameters.AddWithValue("@Revenues", Revenues);
            command.Parameters.AddWithValue("@BoxType", BoxType);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            command.Parameters.AddWithValue("@FK_CurrencyBox", CurrencyID);
            

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedBoxID))
                {
                    Boxid = insertedBoxID;
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

            return Boxid;

        }
        public static bool UpdateBox(int BoxID,int UserID,string BoxName, double BoxBalence, double Revenues, string BoxType)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Boxes  
                            set UserID = @UserID, 
                                BoxName = @BoxName ,
                                BoxBalence = @BoxBalence,
                                Revenues = @Revenues,
                                BoxType =@BoxType
                                where BoxID = @BoxID ";


            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@BoxID", BoxID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@BoxName", BoxName);
            command.Parameters.AddWithValue("@BoxBalence", BoxBalence);
            command.Parameters.AddWithValue("@Revenues", Revenues);
            command.Parameters.AddWithValue("@BoxType", BoxType);
            //command.Parameters.AddWithValue("@Date", Date);



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
        public bool UpdateBoxestatus(int BoxID, int BoxestatusID)
        {
            int RowsAffected = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Boxes SET BoxestatusID = @BoxestatusID WHERE BoxID = @BoxID ";
            SqlCommand comm = new SqlCommand(query, conn);

            comm.Parameters.AddWithValue("@BoxestatusID", BoxestatusID);
            comm.Parameters.AddWithValue("@BoxID", BoxID);

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

            return RowsAffected > 0;
        }
        public static bool UpdateRevenuesField(int ID ,double Revenues)
        {
            int RowsAffected = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Boxes SET Revenues = @Revenues WHERE UserID = @UserID ";
            SqlCommand comm = new SqlCommand(query, conn);

            comm.Parameters.AddWithValue("@Revenues", Revenues);
            comm.Parameters.AddWithValue("@UserID", ID);

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

            return RowsAffected > 0;

        }
        public static DataTable GetAllBoxesInfo()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Boxes";

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
        public static int GetIdOfUserBox(int UserID)
        {
            int BoxID = 0;
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * From Boxes WHERE UserID =@UserID ";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    BoxID = (int)reader["BoxID"];
                }
                reader.Close();

            }
            catch (SqlException ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return BoxID;

        }
        public static DataTable GetAllRemittancingTransfers()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //int TransferID,  string , DateTime 
            //string query = " SELECT  Ttype.Name ,T.Amount , FullName = 'NonClient.FName ' + ' NonClient.LName' , Reciever Boxes T  FROM RemittancingTransfers  ";
            /*
             
            int BoxID,ref int BoxID, ref int SenderID, ref int RecierverID,ref int SourceBranchID,
            ref int TargeteBranchID, ref string Box_Status_ID 
            , ref double FeeAmount , ref int CurrencyID , ref double TransferAmount , ref DateTime Date_Box, ref string Description 

             */
            string query = @"SELECT 
                t.BoxAmount,nc.SenderName,nc.SenderPhone ,
                nc.ReceiverName , currecy.CurrencyName , ts.StatusName , ts.StatusDescription
                FROM Boxes rt
                INNER JOIN Boxes t ON rt.TransferID = t.TransferID
                INNER JOIN Nonclient nc ON t.nonclient_id = nc.nonclient_id
                INNER JOIN Currency currency ON t.CurrencyID = currency.CurrencyID
                INNER JOIN Boxestatus ts ON t.status_id = ts.status_id ";

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
        public static bool DeleteBox(int BoxID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Boxes
                                where BoxID = @BoxID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BoxID", BoxID);

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
        public static bool IsBoxExist(int BoxID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Boxes WHERE BoxID = @BoxID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BoxID", BoxID);

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
        public static bool UpdateBoxestatus(int BoxID, string Boxestatus)
        {
            int RowsAffective = 0;

            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Update Boxes set Boxestatus =@Boxestatus WHERE BoxID = @BoxID ";

            SqlCommand command = new SqlCommand(Query, conn);

            command.Parameters.AddWithValue("@BoxID", BoxID);
            command.Parameters.AddWithValue("@Boxestatus", Boxestatus);

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


            return (RowsAffective > 0);
        }


    }
}
