using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DataAccessGymSystem
{
    public class DataAccessMember
    {
        static public int AddNewMemberGetID(int PersonID,string EmergencyNumber)
        {
            int MemberID = -1;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary= "Insert into Members values(@PersonID,@EmergencyNumber);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command=new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            if(EmergencyNumber=="")
                command.Parameters.AddWithValue("@EmergencyNumber", DBNull.Value);
            else
            command.Parameters.AddWithValue("@EmergencyNumber", EmergencyNumber);

           

            try
            {
                connection.Open();

                object Result= command.ExecuteScalar();
                if (Result != null)
                {
                    MemberID= Convert.ToInt16(Result);

                }


            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }
            return MemberID;

        }

        static public bool FindMemberByID(int MemberID,ref int PersonID,ref string EmergencyNumber)
        {
            bool isFound=false;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from Members where MemberID=@MemberID";

            SqlCommand command=new SqlCommand(quary,connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = Convert.ToInt16(reader["PersonID"]);

                    if (reader["EmergencyNumber"] == DBNull.Value)
                        EmergencyNumber = "";
                    else
                    EmergencyNumber = Convert.ToString(reader["EmergencyNumber"]);

                   
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }
            finally { connection.Close(); }
            return isFound;
        }
        static public bool FindMemberByID2(int MemberID, ref int PersonID, ref string EmergencyNumber)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "EXEC SP_FindMemberByID \r\n@MemberID=@@MemberID";

            SqlCommand command = new SqlCommand(quary, connection);
            command.Parameters.AddWithValue("@@MemberID", MemberID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = Convert.ToInt16(reader["PersonID"]);

                    if (reader["EmergencyNumber"] == DBNull.Value)
                        EmergencyNumber = "";
                    else
                        EmergencyNumber = Convert.ToString(reader["EmergencyNumber"]);


                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }
            finally { connection.Close(); }
            return isFound;
        }

        static public bool UpdateMember(int MemberID, string EmergencyNumber)
        {
            int RowAffected = 0;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "update Members\r\nset EmergencyNumber=@EmergencyNumber\r\nwhere MemberID=@MemberID;";

            SqlCommand command = new SqlCommand(quary, connection);

            command.Parameters.AddWithValue("@EmergencyNumber", EmergencyNumber);
       
            command.Parameters.AddWithValue("@MemberID", MemberID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally{ connection.Close(); }

            return (RowAffected > 0);

        }

        static public bool DeleteMember(int MemeberID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "Delete Members where MemberID=@MemberID";

            SqlCommand command = new SqlCommand(quary, connection);
            command.Parameters.AddWithValue("@MemberID", MemeberID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }
            finally
            {
                connection.Close();
            }

            return (RowAffected > 0);
        }

        static public DataTable GetMemberInfo()
        {
            DataTable dt=new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "select *from MemberDetails";

            SqlCommand command = new SqlCommand(quary,connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally { connection.Close(); }
            return dt;

            




        }

        static public DataTable GetMemberInfoWay2()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "exec SP_GetAllMembersDetails";

            SqlCommand command = new SqlCommand(quary, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally { connection.Close(); }
            return dt;






        }

        static public DataTable GetMembersFilterByID(int MemberID)

        {
            DataTable dt = new DataTable() ;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "Select *from MemberDetails where MemberID=@MemberID";

            SqlCommand command = new SqlCommand(quary, connection);
            
            command.Parameters.AddWithValue("@MemberID", MemberID);

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

                Console.WriteLine(ex.Message.ToString());
            }
            finally { connection.Close(); }
            return dt;
        }

        static public DataTable GetMembersFilterByName(string Name)

        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            string quary = "select * from MemberDetails where name like '" + Name + '%' + '\'';

            SqlCommand command = new SqlCommand(quary, connection);

            

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

                Console.WriteLine(ex.Message.ToString());
            }
            finally { connection.Close(); }
            return dt;
        }

        static public int getCountOFActiveMembers()
        {
            int Count = 0;
            SqlConnection connection=new SqlConnection(Settings.ConnectionString);

            string quary = "Select count(*) from Members join Persons on Members.PersonID=Persons.PersonID where Persons.isActive=1";
            SqlCommand command = new SqlCommand(quary, connection); 
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                int.TryParse(result.ToString(), out Count);

                     
            }
            catch { }
            finally { connection.Close(); }
            return Count;
        }

    }
}
