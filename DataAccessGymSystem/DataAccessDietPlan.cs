using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessGymSystem
{
    public class DataAccessDietPlan
    {

        // Add a new Diet Plan
        static public int AddNewDietPlan(string Name, string Description, string Category, string WeeklyMealPlan)
        {
            int DietPlanID = -1;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string query = "INSERT INTO DietPlans (Name, Description, Category, WeeklyMealPlan) " +
                           "VALUES (@Name, @Description, @Category, @WeeklyMealPlan); " +
                           "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Category", Category);
            command.Parameters.AddWithValue("@WeeklyMealPlan", WeeklyMealPlan);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    DietPlanID = Convert.ToInt32(result);
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

            return DietPlanID;
        }

        // Find Diet Plan by DietPlanID
        static public bool FindDietPlanByID(int DietPlanID, ref string Name, ref string Description, ref string Category, ref string WeeklyMealPlan)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string query = "SELECT * FROM DietPlans WHERE DietPlanID = @DietPlanID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DietPlanID", DietPlanID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Name = reader["Name"].ToString();
                    Description = reader["Description"].ToString();
                    Category = reader["Category"].ToString();
                    WeeklyMealPlan = reader["WeeklyMealPlan"].ToString();
                    isFound = true;
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

            return isFound;
        }

        static public bool FindDietPlanByName(string Name, ref int DietPlanID, ref string Description, ref string Category, ref string WeeklyMealPlan)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string query = "SELECT * FROM DietPlans WHERE Name = @Name";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    DietPlanID = Convert.ToInt32(reader["DietPlanID"]);
                    Description = reader["Description"].ToString();
                    Category = reader["Category"].ToString();
                    WeeklyMealPlan = reader["WeeklyMealPlan"].ToString();
                    isFound = true;
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

            return isFound;
        }

        static public bool UpdateDietPlan(int DietPlanID, string Name, string Description, string Category, string WeeklyMealPlan)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string query = "UPDATE DietPlans " +
                           "SET Name = @Name, Description = @Description, Category = @Category, WeeklyMealPlan = @WeeklyMealPlan " +
                           "WHERE DietPlanID = @DietPlanID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Category", Category);
            command.Parameters.AddWithValue("@WeeklyMealPlan", WeeklyMealPlan);
            command.Parameters.AddWithValue("@DietPlanID", DietPlanID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        static public bool DeleteDietPlan(int DietPlanID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string query = "DELETE FROM DietPlans WHERE DietPlanID = @DietPlanID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DietPlanID", DietPlanID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        static public DataTable GetAllDietPlans()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string query = "SELECT * FROM DietPlans";
            SqlCommand command = new SqlCommand(query, connection);

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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
    }

}
