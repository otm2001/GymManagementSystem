using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessGymSystem
{
    public class DataAccessSuspendedSubscriptions
    {
       static  public int AddnewSuspededSubscription(int SubscriptionID,DateTime SuspendedDate,int RemainingDays)
        {
            int _SuspendedID = -1;

            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "insert into SuspendedSubscriptions values(@SubID,@SuspendedDate,@RemainingDays);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@SubID",SubscriptionID);
            command.Parameters.AddWithValue("@SuspendedDate", SuspendedDate);
            command.Parameters.AddWithValue("@RemainingDays", RemainingDays);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {

                    _SuspendedID = Convert.ToInt16(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return _SuspendedID;
        }
        
        static public bool FindBySubscriptionID(int SubscripitonID,ref int SuspendedID,ref DateTime SuspendedDate,ref int RemainingDays)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "select *from SuspendedSubscriptions where SubscriptionID=@SubscriptionID";

            SqlCommand command = new SqlCommand(quary,connection);

            command.Parameters.AddWithValue("@SubscriptionID", SubscripitonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    SuspendedID = Convert.ToInt16(reader["SuspendedID"]);
                    SuspendedDate = Convert.ToDateTime(reader["SuspendedDate"]);
                    RemainingDays = Convert.ToInt16(reader["RemainingDays"]);
                    isFound = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString() );

            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }

        static public bool UpdateSuspendedSubscription(int SuspendedID, DateTime SuspendedDate,  int RemainingDays)
        {
            int RowAffected = 0;
            SqlConnection connection= new SqlConnection(Settings.ConnectionString);

            string quary = "UPDATE SuspendedSubscriptions\r\n   set   SuspendedDate=@SuspendedDate,\r\n      RemainingDays = @RemainingDays\r\n where SuspendedID=@SuspendedID; ";
            SqlCommand command = new SqlCommand(quary, connection);
            command.Parameters.AddWithValue("@SuspendedDate", SuspendedDate);
            command.Parameters.AddWithValue("@RemainingDays", RemainingDays);
            command.Parameters.AddWithValue("@SuspendedID", SuspendedID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.ToString()}");   
            }
            finally { connection.Close(); }
            return (RowAffected > 0);
        }

        static public bool DeleteSuspendedSubscription(int SuspendedID)
        {
            int RowAffected = 0;
            SqlConnection connection= new SqlConnection(Settings.ConnectionString);

            string quary = "Delete SuspendedSubscriptions where SuspendedID=@SuspendedID";

            SqlCommand command = new SqlCommand(quary, connection);
            command.Parameters.AddWithValue("@SuspendedID", SuspendedID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();



            }
            catch (Exception ex) { Console.WriteLine(ex.Message ); } 
            finally { connection.Close(); } 
            return (RowAffected > 0);
        }

        static public DataTable GetAllSuspendedSubscriptions()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from SuspendedSubscriptionsDetails";

            SqlCommand command = new SqlCommand(quary, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            finally { connection.Close(); }
            return dt;
        }
    }
}
