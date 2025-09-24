using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessGymSystem
{
    public class DataAccessSubscription
    {

        static public int AddNewSubscription(DateTime StartDate, DateTime EndDate, int MemberID, int CoachID, int GameID, char SubscriptionsType,int NumberOFDays, float Fee, int PaymentID)
        {
            int subscriptionID = -1;

            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Insert into Subscriptions values(@StartDate,@EndDate,@MemberID,@CoachID,@GameID,@Subscriptions_Type,@NumberOfDays,@Fee,@PaymentID,@isSuspended);" +
                "select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(quary, connection);


            command.Parameters.AddWithValue("@StartDate", StartDate);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@CoachID", CoachID);
            command.Parameters.AddWithValue("@GameID", GameID);
            command.Parameters.AddWithValue("@Subscriptions_Type", SubscriptionsType);
            command.Parameters.AddWithValue("@NumberOfDays",NumberOFDays);
            command.Parameters.AddWithValue("@Fee", Fee);
            command.Parameters.AddWithValue("@PaymentID",PaymentID);
            command.Parameters.AddWithValue("@isSuspended",false);




            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                    subscriptionID = Convert.ToInt16(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally { connection.Close(); }
            return subscriptionID;
        }

        static public bool UpdateSubscription(int SubscriptionID, DateTime StartDate, DateTime EndDate, int MemberID, int CoachID, int GameID, char SubscriptionsType,int NumberOfDays, float Fee,bool isSuspended)
        {
            int RowAffeced = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "UPDATE Subscriptions\r\n   SET StartDate = @StartDate\r\n      ,EndDate = @EndDate\r\n      ,MemberID = @MemberID\r\n      ,CoachID = @CoachID\r\n      ,GameID = @GameID\r\n      ,Subscriptions_Type = @Subscriptions_Type\r\n ,NumberOfDays=@NumberOfDays\r\n     ,Fee = @Fee\r\n,isSuspended=@isSuspended \r\nWHERE SubscriptionID=@SubscriptionID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@StartDate", StartDate);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@CoachID", CoachID);
            command.Parameters.AddWithValue("@GameID", GameID);
            command.Parameters.AddWithValue("@Subscriptions_Type", SubscriptionsType);
            command.Parameters.AddWithValue("@NumberOfDays", NumberOfDays);
            command.Parameters.AddWithValue("@Fee", Fee);
            command.Parameters.AddWithValue("@isSuspended", isSuspended);
            command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);
            try
            {
                connection.Open();
                RowAffeced = command.ExecuteNonQuery();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }
            finally { connection.Close(); }

            return (RowAffeced > 0);
        }

        static public bool FindSubscription(int SubscriptionID, ref DateTime StartDate, ref DateTime EndDate, ref int MemberID, ref int CoachID, ref int GameID, ref char SubscriptionsType,ref int NumberOfDays, ref float Fee, ref int PaymentID)
        { bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from Subscriptions where SubscriptionID=@SubscriptionID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    StartDate = Convert.ToDateTime(reader["StartDate"]);
                    EndDate = Convert.ToDateTime(reader["EndDate"]);
                    MemberID = Convert.ToInt16(reader["MemberID"]);
                    CoachID = Convert.ToInt16(reader["CoachID"]);
                    GameID = Convert.ToInt16(reader["GameID"]);
                    SubscriptionsType = Convert.ToChar(reader["Subscriptions_Type"]);
                    NumberOfDays = Convert.ToInt16(reader["NumberOfDays"]);
                    Fee = Convert.ToSingle(reader["Fee"]);
                    PaymentID = Convert.ToInt16(reader["PaymentID"]);
                    isFound = true;
                }
                reader.Close();

            } catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            finally { connection.Close(); }
            return isFound;
        }

        static public bool DeleteSubscription(int SubscriptionID)
        {
            int RowAffeced=0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Delete Subscriptions where SubscriptionID=@SubscriptionID";
            SqlCommand command = new SqlCommand(quary, connection);
            command.Parameters.AddWithValue("@SubscriptionID", SubscriptionID);

            try
            {
                connection.Open();

                RowAffeced = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return (RowAffeced > 0);
        } 

        static public DataTable GetAllSuvsriptions()
        {
            DataTable dt= new DataTable();  
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "SELECT *FROM SubscriptionsDetails";
            SqlCommand command = new SqlCommand(quary, connection); 
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch(Exception ex)
            {

            Console.WriteLine(ex.Message); } 
            finally { connection.Close(); }
            return dt;
        }

        static public DataTable GetSubsriptionsperGame()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "select SubscriptionsDetails.GameName , Count(*) as GCount from SubscriptionsDetails\r\nwhere SubscriptionsDetails.status='Active'\r\ngroup by(SubscriptionsDetails.GameName);\r\n";
            SqlCommand command = new SqlCommand(quary, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }
            return dt;
        }
    }

    }

