using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessGymSystem
{
    public class DataAccessCoach
    {

        static public int addNewCoachGetID(int EmployeeID, string Qualification,int GameID)
        {
            int CoachID = -1;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "Insert into Coaches values(@EmployeeID,@Qualification,@GameID);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@Qualification", Qualification);
            command.Parameters.AddWithValue("@GameID",GameID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                {
                    CoachID = Convert.ToInt16(Result);
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
            return CoachID;
        }

        static public bool FindCoachByID(int CoachID, ref int EmployeeID, ref string Qualification,ref int GameID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from Coaches where CoachID=@CoachID";

            SqlCommand command = new SqlCommand(quary,connection);

            command.Parameters.AddWithValue("@CoachID", CoachID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    EmployeeID = (int)reader["EmployeeID"];
                    Qualification = Convert.ToString(reader["Qualification"]);
                    GameID = Convert.ToInt16(reader["GameID"]);
                    IsFound = true;
                }
                reader.Close();

            } 
            catch (Exception ex) {
                Console.WriteLine(ex.Message.ToString());
                    }

            finally { connection.Close(); } 

            return IsFound;


        }

       
                
        static public bool UpdateCoach(int CoachID, string Qualification,int GameID)
        {
            int RowAffected = 0;
            SqlConnection connection= new SqlConnection(Settings.ConnectionString);

            string quary = "\r\nupdate Coaches\r\nset Qualification=@Qualification\r\n,GameID=@GameID\r\n where CoachID=@CoachID;";

            SqlCommand command = new SqlCommand(quary,connection);

            command.Parameters.AddWithValue("@Qualification", Qualification);
            command.Parameters.AddWithValue("@CoachID", CoachID);
            command.Parameters.AddWithValue("@GameID", GameID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();

               

            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally { connection.Close(); }
            return (RowAffected > 0);
        }

        static public bool DeleteCoach(int CoachID)
        {
            int RowAffected=0; 
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "Delete Coaches where CoachID=@CoachID";

            SqlCommand command = new SqlCommand(quary,connection );
            command.Parameters.AddWithValue("@CoachID", CoachID);

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());

            }
            finally{ connection.Close(); }
            return (RowAffected > 0);




        }

        static public DataTable GetAllCoachesInfo()
        {
            DataTable result = new DataTable();

            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "select *from CoachesDetails";

            SqlCommand command = new SqlCommand( quary,connection );

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
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message.ToString());
            }
            finally { connection.Close(); }
            return result;
        }

        static public DataTable GetAllCoachesWithFilter(string GameName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from CoachesDetails where GameName=@GameName";
            SqlCommand command = new SqlCommand(quary,connection);

            command.Parameters.AddWithValue("@GameName", GameName);

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
            catch (Exception ex) { Console.WriteLine (ex); } 

            finally { connection.Close(); }

            return dt;
        }

        static public bool FindCoachEmployeeID(int EmployeeID, ref int CoachID)
        {
    
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string qaury = "Select *FROM Coaches where Coaches.EmployeeID=@EmployeeID";

            SqlCommand command = new SqlCommand(qaury,connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CoachID = Convert.ToInt16(reader["CoachID"]);
                    isFound = true;
                }
            } catch (Exception ex) { Console.WriteLine (ex.Message); }
            finally
            { connection.Close(); }  
            return isFound;

        }

        static public bool FindCoachName(string Name, ref int CoachID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string qaury = "Select *FROM CoachesDetails where CoachesDetails.Name=@Name";

            SqlCommand command = new SqlCommand(qaury, connection);

            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CoachID = Convert.ToInt16(reader["CoachID"]);
                    isFound = true;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            { connection.Close(); }
            return isFound;

        }

    }
}
