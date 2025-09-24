using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessGymSystem
{
    public  class DataAccessExpense
    {
        public static int AddNewExpense(int ExpenseTypeID,float Amount,DateTime ExpenseDate,int UserID)
        {
            int ExpenseID = -1;

            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "Insert into Expenses values(@ExpenseTypeID,@Amount,@ExpenseDate,@UserID);" +
                "select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@ExpenseTypeID", ExpenseTypeID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@ExpenseDate", ExpenseDate);
            command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    ExpenseID = Convert.ToInt16(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
            finally { connection.Close(); }
            return ExpenseID;

                
            return 0;
        }

        public static bool FindExpensebyID(int ExpenseID,ref float Amount, ref int ExpenseTypeID,ref DateTime ExpenseDate,ref int UserID)
        {
            bool isFound=false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quray = "Select *from Expenses where ExpenseID=@ExpenseID";

            SqlCommand command = new SqlCommand(quray, connection);

            command.Parameters.AddWithValue("@ExpenseID", ExpenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ExpenseTypeID = Convert.ToInt16(reader["ExpenseTypeID"]);
                    Amount = Convert.ToSingle(reader["Amount"]);
                    ExpenseDate = Convert.ToDateTime(reader["ExpenseDate"]);
                    UserID = Convert.ToInt16(reader["UserID"]);
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return isFound;
            }

        public static bool UpdateExpense(int ExpenseID, float Amount, int ExpenseTypeID,  DateTime ExpenseDate,  int UserID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "UPDATE [dbo].[Expenses]\r\n   SET ExpenseTypeID = @ExpenseTypeID\r\n      ,Amount = @Amount\r\n      ,ExpenseDate =@ExpenseDate\r\n      ,UserID = @UserID\r\n WHERE Expenses.ExpenseID=@ExpenseID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@ExpenseTypeID", ExpenseTypeID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@ExpenseDate", ExpenseDate);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ExpenseID", ExpenseID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { connection.Close(); }
            return (RowAffected > 0);
        }

        public static bool DeleteExpense(int ExpenseID)
        {
            int RowAffected = 0;
            SqlConnection connection= new SqlConnection(Settings.ConnectionString);

            string quary = "Delete Expenses where ExpenseID=@ExpenseID";

            SqlCommand command = new SqlCommand(quary,connection);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            finally { connection.Close(); }
            return (RowAffected > 0);
        }

        public static DataTable GetAllExpenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string quary = "Select * from ExpensesDetails";
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

