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
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SP_DeletePatient";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue(@"PatientID", PatientID);
                        connection.Open();

                        rowAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                clsEventLog.LogOrCreateEventSoures(ex.Message);
            }

            return (rowAffected > 0);
        }

        public static int AddNewPatient(string FirstName, string LastName, string Phone, string Email, string Address,
                                            string MedicalNotes, DateTime DateOfBirth, short Gendor, string ImagePath)
        {
            int PatientID = -1;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Quer = "SP_AddNewPatient";
                using (SqlCommand command = new SqlCommand(Quer, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter sqlParameter = new SqlParameter("@NewPatientID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    
                    command.Parameters.AddWithValue(@"FirstName", FirstName);
                    command.Parameters.AddWithValue(@"LastName", LastName);

                    command.Parameters.AddWithValue(@"Phone", Phone);

                    if (Email != "" && Email != null)
                        command.Parameters.AddWithValue(@"Email", Email);
                    else
                        command.Parameters.AddWithValue(@"Email", System.DBNull.Value);

                    command.Parameters.AddWithValue(@"Address", Address);

                    command.Parameters.AddWithValue(@"MedicalNotes", MedicalNotes);

                    command.Parameters.AddWithValue(@"DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue(@"Gendor", Gendor);

                    if (ImagePath != "" && ImagePath != null)
                        command.Parameters.AddWithValue(@"ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue(@"ImagePath", System.DBNull.Value);

                    command.Parameters.Add(sqlParameter);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        if(sqlParameter.Value != DBNull.Value)
                        {
                            PatientID = Convert.ToInt32(sqlParameter.Value);
                        }
                        
                    }

                    catch (Exception ex)
                    {
                        clsclsEventLog.LogOrCreateEventSoures(ex.Message);
                    }

                }

            }


            return PatientID;
        }

    }
}
