using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessGymSystem
{
    public class DataAccessEmployee
    {
        static public int AddNewEmployee(int PersonID,float Salary,int jobRoleID)
        {
            int EmployeeID = -1;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary="Insert into Employees values(@PersonID,@Salary,@JobRoleID)" +
                 "select SCOPE_IDENTITY();";

            SqlCommand command=new SqlCommand(quary, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Salary",Salary);
            command.Parameters.AddWithValue("@JobRoleID", jobRoleID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    EmployeeID = Convert.ToInt16(result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { connection.Close(); }
            return EmployeeID;

        }

        static public bool FindEmployeeByID(int EmployeeID,ref int PersonID,ref float Salary,ref int jobRoleID)
        {
            bool isFound = false;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);
            string quary = "Select *from Employees where EmployeeID=@EmployeeID";
            SqlCommand command=new SqlCommand(quary,connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    PersonID = Convert.ToInt16(reader["PersonID"]);
                    Salary = Convert.ToSingle(reader["Salary"]);
                    jobRoleID = Convert.ToInt16(reader["JobRoleID"]);
                    isFound = true;
                }
                reader.Close();

            }
            catch(Exception ex)
            { Console.WriteLine(ex.ToString()); }

            finally { connection.Close(); }
            return isFound;
        }

        static public bool UpdateEmployeeInfo(int EmployeeID,float Salary,int JobRoleID)
        {
            int RowAffected = 0;
            SqlConnection connection= new SqlConnection(Settings.ConnectionString);

            string quary = "\r\nUPDATE [dbo].[Employees]\r\n   SET Salary =@Salary\r\n      ,JobRoleID =@JobRoleID\r\n WHERE Employees.EmployeeID=@EmployeeID;";
            SqlCommand command=new SqlCommand(quary,connection );

            command.Parameters.AddWithValue("@Salary", Salary);
            command.Parameters.AddWithValue("@JobRoleID", JobRoleID);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch(Exception ex) { Console.WriteLine(ex.Message); } 
            finally { connection.Close(); }
            return (RowAffected > 0);
        }

        static public bool DeleteEmployee(int EmployeeID)
        {
            int rowAffected= 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Delete Employees where EmployeeID=@EmployeeID";
            SqlCommand command=new SqlCommand( quary,connection );
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();

            }
            catch(Exception ex) { Console.WriteLine(ex); } 
            finally { connection.Close(); }
            return (rowAffected > 0);

        }

        static public DataTable GetAllEmployeesDetails()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "select *from EmployeesDetails";
            SqlCommand command = new SqlCommand( quary,connection );
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
