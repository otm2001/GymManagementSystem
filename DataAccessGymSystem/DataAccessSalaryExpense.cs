using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessGymSystem
{
    public class DataAccessSalaryExpense
    {
        public static int AddNewSalaryExpense(int EmployeeID,float Salary,int ExpenseID)
        {
            int SalaryExpenseID = -1;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "Insert Into SalariesExpenses Values(@EmployeeID,@Salary,@ExpenseID);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command=new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@Salary", Salary);
            command.Parameters.AddWithValue("@ExpenseID", ExpenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null)
                {
                    SalaryExpenseID = Convert.ToInt16(result);
                }

            }
            catch { }
            finally { connection.Close(); }
            return SalaryExpenseID;
        
        }

        public static bool FindSalaryExpenseByID(int SalaryExpenseID,ref  int EmployeeID, ref float Salary, ref int ExpenseID)
        {
            bool isFound=false;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from SalariesExpenses where SalaryExpenseID=@SalaryExpenseID";

            SqlCommand command=new SqlCommand(quary,connection);
            command.Parameters.AddWithValue("@SalaryExpenseID", SalaryExpenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    EmployeeID = Convert.ToInt16(reader["EmployeeID"]);
                    Salary = Convert.ToSingle(reader["Salary"]);
                    ExpenseID = Convert.ToInt16(reader["ExpenseID"]);
                    isFound = true;
                }

            } catch { }

            finally { connection.Close(); }
            return isFound;
        }


        public static bool FindSalaryExpenseByEmployeeID(int EmployeeID,ref int SalaryExpenseID  ,ref float Salary, ref int ExpenseID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from SalariesExpenses where EmployeeID=@EmployeeID";

            SqlCommand command = new SqlCommand(quary, connection);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    SalaryExpenseID = Convert.ToInt16(reader["SalaryExpenseID"]);
                    Salary = Convert.ToSingle(reader["Salary"]);
                    ExpenseID = Convert.ToInt16(reader["ExpenseID"]);
                    isFound = true;
                }

            }
            catch { }

            finally { connection.Close(); }
            return isFound;
        }

        public static bool UpdateSalaryExpense(int SalaryExpenseID,  int EmployeeID,  float Salary)
        {
            int RowAffeted=0;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "UPDATE [dbo].[SalariesExpenses]\r\n   SET EmployeeID = @EmployeeID\r\n      ,Salary = @Salary\r\n WHERE SalariesExpenses.SalaryExpenseID=@SalaryExpenseID";

            SqlCommand command=new SqlCommand(quary,connection );

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@Salary", Salary);
            command.Parameters.AddWithValue("@SalaryExpenseID", SalaryExpenseID);

            try
            {
                connection.Open();
                RowAffeted = command.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
            return (RowAffeted>0);
        }


        public static bool DeleteSalaryExpense(int SalaryExpenseID)
        {
            int RowAffected = 0;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "Delete SalariesExpenses where SalaryExpenseID=@SalaryExpenseID";

            SqlCommand command=new SqlCommand(quary, connection );
            command.Parameters.AddWithValue("@SalaryExpenseID", SalaryExpenseID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch { } finally { connection.Close(); }
            return (RowAffected>0);
        }
    }


}
