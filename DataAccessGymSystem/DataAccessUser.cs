using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessGymSystem
{
    public class DataAccessUser
    {

        static public int AddNewUser(int EmployeeID,string UserName,string Password,long Permissions)
        {
            int UserID = -1;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "Insert into Users values(@EmployeeID,@UserName,@Password,@Permissions); select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    UserID = Convert.ToInt16(result);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return UserID;

        }

        static public bool FindUserByUserName(string UserName,ref int UserID,ref int EmployeeID,ref string Password,ref long Permissions)
        {
            bool isFound=false;
           SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from Users where UserName=@UserName";

            SqlCommand command = new SqlCommand(quary,connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    UserID = Convert.ToInt16(reader["UserID"]);
                    EmployeeID= Convert.ToInt16(reader["EmployeeID"]);
                    Password = Convert.ToString(reader["Password"]);
                     long.TryParse(reader["Permissions"].ToString(),out Permissions);
                    isFound = true;
                }
                reader.Close();
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return isFound;

        }
       
        static public bool FindUserByUserID(int UserID,ref string UserName,  ref int EmployeeID, ref string Password,ref long Permissions)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from Users where UserID=@UserID";

            SqlCommand command = new SqlCommand(quary, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserName = Convert.ToString(reader["UserName"]);
                    EmployeeID = Convert.ToInt16(reader["EmployeeID"]);
                    Password = Convert.ToString(reader["Password"]);
                    long.TryParse(reader["Permissions"].ToString(), out Permissions);
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return isFound;

        }

        static public bool UpdateUser(int UserID,int EmployeeID, string UserName, string Password,long Permissions)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "update Users\r\nset EmployeeID=@EmployeeID,\r\nUserName=@UserName,\r\nPassword=@Password,\r\n Permissions=@Permissions\r\nwhere UserID=@UserID;";
            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Permissions", Permissions);

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

        static public bool DeleteUser(int UserID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Delete Users where UserID=@UserID";
            SqlCommand command = new SqlCommand(quary,connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }
            finally { connection.Close(); }

            return (rowAffected > 0);





        }

        static public DataTable GetAllUsersDetails()
        {
            DataTable result = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select * from UsersDetails";
            SqlCommand command = new SqlCommand(quary, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    result.Load(reader);
                }
                reader.Close();

            }
            catch
            { }
            finally { connection.Close(); }
            return result;

        }
    }
}
