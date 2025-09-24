using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessGymSystem
{
    public class DataAccessPereson
    {

        static public bool FindPersonByID(int PersonID, ref string Name, ref string Address, ref string Phone, ref DateTime BirthOfDate, ref char Gender, ref string ImagePath,ref string Email,ref bool isActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from Persons where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Name = (string)reader["Name"];
                    Phone = (string)reader["Phone"];
                    BirthOfDate = (DateTime)reader["BirthOfDate"];
                    Gender = Convert.ToChar(reader["Gender"]);
                    isActive = Convert.ToBoolean(reader["isActive"]);

                    if (reader["ImagePath"] == DBNull.Value)
                        ImagePath = "";
                    else
                        ImagePath = (string)reader["ImagePath"];

                    if (reader["Address"] == DBNull.Value)
                        Address = "";
                    else
                        Address = (string)reader["Address"];

                    if (reader["Email"] == DBNull.Value)
                        Email = "";
                    else
                        Email = (string)reader["Email"];

                    isFound = true;
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
            return isFound;
        }

        static public bool FindPersonByID2(int PersonID, ref string Name, ref string Address, ref string Phone, ref DateTime BirthOfDate, ref char Gender, ref string ImagePath, ref string Email, ref bool isActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "exec SP_FindPersonByID\r\n@PersonID=@@PersonID;";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Name = (string)reader["Name"];
                    Phone = (string)reader["Phone"];
                    BirthOfDate = (DateTime)reader["BirthOfDate"];
                    Gender = Convert.ToChar(reader["Gender"]);
                    isActive = Convert.ToBoolean(reader["isActive"]);

                    if (reader["ImagePath"] == DBNull.Value)
                        ImagePath = "";
                    else
                        ImagePath = (string)reader["ImagePath"];

                    if (reader["Address"] == DBNull.Value)
                        Address = "";
                    else
                        Address = (string)reader["Address"];

                    if (reader["Email"] == DBNull.Value)
                        Email = "";
                    else
                        Email = (string)reader["Email"];

                    isFound = true;
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
            return isFound;
        }


        /* static public bool FindPersonByName(string Name,ref int PersonID, ref string Address, ref string Phone, ref DateTime BirthOfDate, ref char Gender, ref string ImagePath, ref string Email,ref bool isActive)
         {
             bool isFound = false;
             SqlConnection connection = new SqlConnection(Settings.ConnectionString);

             string quary = "Select *from Persons where Name=@Name";

             SqlCommand command = new SqlCommand(quary, connection);

             command.Parameters.AddWithValue("@Name", Name);

             try
             {
                 connection.Open();
                 SqlDataReader reader = command.ExecuteReader();

                 if (reader.Read())
                 {
                     PersonID = Convert.ToInt16(reader["PersonID"]);
                     Phone = (string)reader["Phone"];
                     BirthOfDate = (DateTime)reader["BirthOfDate"];
                     Gender = Convert.ToChar(reader["Gender"]);

                     if (reader["ImagePath"] == DBNull.Value)
                         ImagePath = "";
                     else
                         ImagePath = (string)reader["ImagePath"];

                     if (reader["Address"] == DBNull.Value)
                         Address = "";
                     else
                         Address = (string)reader["Address"];

                     if (reader["Email"] == DBNull.Value)
                         Email = "";
                     else
                         Email = (string)reader["Email"];

                     isFound = true;
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
             return isFound;
         }
        */
        static public int AddNewPersonGetID(string Name, string Address, string Phone, DateTime BirthOfDate, char Gender, string ImagePath,string Email,bool isActive)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string quary = "Insert into Persons values(@Name,@Address,@Phone,@BirthOfDate,@Gender,@ImagePath,@Email,@isActive);" +
                "select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(quary, connection);
            command.Parameters.AddWithValue("@Name", Name);
           
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@BirthOfDate", BirthOfDate);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@isActive",isActive);
            
            //Handle empty string
            if(ImagePath=="")
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

            if(Address=="")
                command.Parameters.AddWithValue("@Address", DBNull.Value);

            else
                command.Parameters.AddWithValue("@Address", Address);

            if(Email=="")
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", Email);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                {

                    PersonID = Convert.ToInt32(result);

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
            return PersonID;


        }
        static public bool UpdatePerson(int PersonID, string Name, string Address, string Phone, DateTime BirthOfDate, char Gender, string ImagePath,string Email,bool isActive)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "UPDATE Persons\r\n   SET Name =@Name,\r\nAddress = @Address\r\n,Phone = @Phone\r\n,BirthOfDate = @BirthOfDate\r\n,Gender = @Gender\r\n,ImagePath = @ImagePath\r\n,Email = @Email\r\n,isActive=@isActive\r\n WHERE PersonID=@PersonID;";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@BirthOfDate", BirthOfDate);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@isActive", isActive);
            if (ImagePath == "")
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);

            if(Address=="")
                command.Parameters.AddWithValue("@Address", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Address", Address);

            if(Email=="")
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", Email);


            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object result = command.ExecuteNonQuery();

                if ((int)result > 0)
                    isUpdated = true;


            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return isUpdated;
        }
        static public bool DeletePerson(int PersonID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string quary = "Delete Persons where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(quary, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();

               


            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return (RowAffected>0);
        }
    }
}

