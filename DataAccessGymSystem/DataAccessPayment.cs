using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessGymSystem
{
    public class DataAccessPayment
    {

        static public int AddNewPayment(float Amount, DateTime Date, int MemberID)
        {
            int PaymentId = -1;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "insert into Payments values(@Amount,@Date,@MemberID);select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@MemberID", MemberID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    PaymentId = Convert.ToInt16(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

            }
            finally
            {
                connection.Close();
            }
            return PaymentId;

        }

        static public bool FindPaymentByID(int PaymentID, ref float Amount, ref DateTime Date, ref int MemberID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "select *from Payments where PaymentID=@PaymentID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    Amount = Convert.ToSingle(reader["Amount"]);
                    Date = Convert.ToDateTime(reader["Date"]);
                    MemberID = Convert.ToUInt16(reader["MemberID"]);
                    isFound = true;
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { connection.Close(); }

            return isFound;
        }

        static public bool UpdatePayment(int PaymentID, float Amount, DateTime Date, int MemberID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "update Payments\r\nset Amount=@Amount,\r\nDate=@Date,\r\nMemberID=@MemberID\r\nwhere PaymentID=@PaymentID;";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@MemberID", MemberID);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }

            return (RowAffected > 0);
        }

        static public bool DeletePayment(int PaymentID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string quray = "Delete Payments where PaymentID=@PaymentID";

            SqlCommand command = new SqlCommand(quray, connection);

            command.Parameters.AddWithValue("@PaymentID",PaymentID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally{ connection.Close(); }

            return (RowAffected > 0);
        }

        static public DataTable GetAllPayments()
        {
            DataTable dt= new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from PaymentsDetails";
            SqlCommand command= new SqlCommand(quary, connection); 
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
               
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }

        static public DataTable GetAllPaymentsByName(string Name)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "select *from PaymentsDetails where PaymentsDetails.PaidBy like '" + Name + '%' + '\'';
            SqlCommand command = new SqlCommand(quary, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);

            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }
    }
}
