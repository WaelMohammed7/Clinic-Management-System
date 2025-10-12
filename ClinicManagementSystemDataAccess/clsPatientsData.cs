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
    public class clsPatientsData
    {
        public static DataTable GetAllPatients()
        {
            DataTable dt = new DataTable();



            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SP_GetAllPatients";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                          
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogOrCreateEventSoures(ex.Message);
                    }

                }
            }
            return dt;

        }

       public static bool DeletePatient(int PatientID)
        {
            int rowAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SP_DeletePatient";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue(@"PatientID", PatientID);
                        connection.Open();

                        rowAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch(Exception ex)
            {
                clsEventLog.LogOrCreateEventSoures(ex.Message);
            }

            return (rowAffected >0);
        }

        public static int AddNewPatient(int PatientID)
        {
            int rowAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string Quer = "";
                    using(SqlCommand command = new SqlCommand(Quer, connection))
                    {
                        command.Parameters.AddWithValue(@"", PatientID);
                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            rowAffected = reader.HasRows;
                        }


                    }
                }
            }
            catch(Exception ex)
            {
                
            }
        }
    }
}
