using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic_Management_System.Global;

namespace ClinicManagementSystemDataAccess
{
    public class clsUserData
    {
        public static DataTable GetAllUserManagement()
        {
            DataTable de = new DataTable();
            string quer = @"Select  UserID,UserName,IsActive from Users";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(quer, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                
                try
                {
                    if (reader.HasRows)
                    {
                        de.Load(reader);
                    }
                    reader.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    connection.Close();
                }

            }


            return de;
            
        }

        public static bool GetUserInfoByUsernameAndPassword(string UserName, string Password, ref int UserId, /*ref byte Role,*/ ref byte IsActive)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;
                            UserId = (int)reader["UserId"];
                            UserName = (string)reader["Username"];
                            Password = (string)reader["Password"];
                          //  Role = Convert.ToByte(reader["Role"]);
                            IsActive = Convert.ToByte(reader["IsActive"]);
                        }
                        else
                        {
                            IsFound = false;
                        }
                        reader.Close();

                    }
                }
            }

            catch (Exception ex)
            {
                clsEventLog.LogOrCreateEventSoures(ex.Message);
            }

            return IsFound;
        }
    }



}
