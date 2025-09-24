using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessGymSystem
{
    public class JobRolesDatatAccesscs
    {

        public static int AddNewJobRole(string JobRoleName)
        {
            int JobRoleID = -1;

            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Insert into JobRoles values(@JobRoleName);" +
                "select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@JobRoleName", JobRoleName);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    JobRoleID = Convert.ToInt16(result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }
            return (JobRoleID);
        }

        public static bool FindByJobRoleID(int JobRoleID, ref string JobRoleName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string qaury = "Select *from JobRoles where JobRoleID=@JobRoleID";

            SqlCommand command = new SqlCommand(qaury, connection);
            command.Parameters.AddWithValue("@JobRoleID", JobRoleID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    JobRoleName = Convert.ToString(reader["JobRoleName"]);
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            finally { connection.Close(); }

            return isFound;
        }

        public static bool FindByJobRoleName(string JobRoleName,ref int JobRoleID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string qaury = "Select *from JobRoles where JobRoleName=@JobRoleName";

            SqlCommand command = new SqlCommand(qaury, connection);
            command.Parameters.AddWithValue("@JobRoleName", JobRoleName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    JobRoleID = Convert.ToInt16(reader["JobRoleID"]);
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            finally { connection.Close(); }

            return isFound;
        }

        public static bool DeleteJobRole(int JobRoleId)
        {
            int RowAffected = 0;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "Delete JobRoles where JobRoleID=@JobRoleID";
            SqlCommand command = new SqlCommand(quary, connection);
            command.Parameters.AddWithValue("@JobRoleID", JobRoleId);
            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally { connection.Close(); }
            return (RowAffected > 0);

        }

        public static DataTable GetAllJobRoles()
        {
            DataTable dt=new DataTable();

            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from JobRoles";

            SqlCommand command = new SqlCommand(quary,connection);

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

