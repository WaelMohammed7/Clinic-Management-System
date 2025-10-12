using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagementSystemDataAccess;

namespace ClinicManagementSystemAcesseBussin
{
    public class clsPatients
    {
        public static DataTable GetAllPatients()
        {
            return clsPatientsData.GetAllPatients();
        }

        public static bool DeletePatient(int PatientID)
        {
            return clsPatientsData.DeletePatient(PatientID);
        }
    }
}
