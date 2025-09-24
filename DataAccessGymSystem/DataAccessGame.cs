using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessGymSystem
{
    public class DataAccessGame
    {

        static public int AddNewGame(string GameName, float MonthlyFee, float DailyFee)
        {
            int GameID = -1;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "insert into GymGames values(@GameName,@MonthlyFee,@DailyFee);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@GameName", GameName);
            command.Parameters.AddWithValue("MonthlyFee", MonthlyFee);
            command.Parameters.AddWithValue("DailyFee", DailyFee);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    GameID = Convert.ToInt16(result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }

            return GameID;
        }

        static public bool FindGameByID(int GameID, ref string GameName, ref float MonthlyFee, ref float DailyFee)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from GymGames where GameID=@GameID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@GameID", GameID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    GameName = Convert.ToString(reader["GameName"]);
                    MonthlyFee = Convert.ToSingle(reader["MonthlyFee"]);
                    DailyFee = Convert.ToSingle(reader["DailyFee"]);
                    isFound = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

            }
            finally { connection.Close(); }

            return isFound;

        }

        static public bool FindGameByName(string GameName, ref int GameID, ref float MonthlyFee, ref float DailyFee)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from GymGames where GameName=@GameName";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@GameName", GameName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    GameID = Convert.ToInt16(reader["GameID"]);
                    MonthlyFee = Convert.ToSingle(reader["MonthlyFee"]);
                    DailyFee = Convert.ToSingle(reader["DailyFee"]);
                    isFound = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

            }
            finally { connection.Close(); }

            return isFound;

        }

        static public bool UpdateGame(int GameID, string GameName, float MonthlyFee, float DailyFee)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "UPDATE GymGames\r\n   SET GameName =@GameName\r\n      ,MonthlyFee = @MonthlyFee\r\n      ,DailyFee = @DailyFee\r\n WHERE GameID=@GameID;";
            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@GameName", GameName);
            command.Parameters.AddWithValue("@MonthlyFee", MonthlyFee);
            command.Parameters.AddWithValue("@DailyFee", DailyFee);
            command.Parameters.AddWithValue("@GameID", GameID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

            }

            finally { connection.Close(); }
            return (RowAffected > 0);
        }

        static public bool DeleteGame(int GameID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string quary = "Delete GymGames where GameId=@GameID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("GameID",GameID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally { connection.Close(); }

            return (RowAffected > 0);



        }

        static public DataTable GetAllGames()
        {
            DataTable dt=new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from GymGames;";

            SqlCommand command = new SqlCommand(quary,connection);

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
            catch (Exception ex)
            {

                Console.WriteLine (ex.Message.ToString());
            }
            finally { connection.Close(); }
            return dt;
        }

      
    }
}
