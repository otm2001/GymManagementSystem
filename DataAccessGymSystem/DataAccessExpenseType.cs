using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessGymSystem
{
    public class DataAccessExpenseType
    {

        public static int AddNewExpenseType(string ExpenseTypeName)
        {
            int ExpenseTypeID = -1;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "insert into ExpensesTypes values(@ExpenseTypeName)" +
                "select SCOPE_IDENTITY();";
            SqlCommand command=new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@ExpenseTypeName", ExpenseTypeName);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    ExpenseTypeID = Convert.ToInt16(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return ExpenseTypeID;
        }

        public static bool FindExpenseTypeByID(int ExpenseTypeID,ref string ExpenseTypeName)
        {
            bool isFound = false; 
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from ExpensesTypes where ExpenseTypeID=@ExpenseTypeID";

            SqlCommand command= new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@ExpenseTypeID", ExpenseTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ExpenseTypeName = Convert.ToString(reader["ExpenseTypeName"]);
                    isFound = true;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }

        public static bool FindExpenseTypeByName(string ExpenseTypeName,ref int ExpenseTypeID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from ExpensesTypes where ExpenseTypeName=@ExpenseTypeName";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@ExpenseTypeName", ExpenseTypeName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ExpenseTypeID = Convert.ToInt16(reader["ExpenseTypeID"]);
                    isFound = true;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }
        public static bool FindExpenseTypeByName(int ExpenseTypeName, ref string ExpenseTypeID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from ExpensesTypes where ExpenseTypeName=@ExpenseTypeName";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@ExpenseTypeName", ExpenseTypeName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ExpenseTypeID = Convert.ToString(reader["ExpenseTypeID"]);
                    isFound = true;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }

        public static bool DeleteExpenseType( int ExpenseTypeID)
        {
            int RowAffeted = 0;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);
            string quary = "Delete ExpensesTypes where ExpenseTypeID=@ExpenseTypeID";
            SqlCommand command = new SqlCommand( quary, connection);
            command.Parameters.AddWithValue("@ExpenseTypeID", ExpenseTypeID);

            try
            {
                connection.Open();
                RowAffeted = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return( RowAffeted > 0);
        }

        public static DataTable GetAllExpensesTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection= new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from ExpensesTypes";
            SqlCommand command= new SqlCommand( quary, connection);
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
