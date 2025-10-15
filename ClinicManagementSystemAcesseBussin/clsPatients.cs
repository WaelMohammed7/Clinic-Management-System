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
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string MedicalNotes { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }
        public string ImagePath { get; set; }

        public clsPatients()
        {
            this.PatientID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Phone = "";
            this.Email = "";
            this.Address = "";
            this.MedicalNotes = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.ImagePath = "";
            Mode = enMode.AddNew;

        }

        public clsPatients(int patientID, string firstName, string lastName, string phone, string email, string address,
                                                      string medicalNotes, DateTime dateOfBirth, short gendor, string imagePath)
        {
            this.PatientID = patientID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.MedicalNotes = medicalNotes;
            this.DateOfBirth = dateOfBirth;
            this.Gendor = gendor;
            this.ImagePath = imagePath;

            Mode = enMode.Update;
        }

        public static DataTable GetAllPatients()
        {
            return clsPatientsData.GetAllPatients();
        }

        public static bool DeletePatient(int PatientID)
        {
            return clsPatientsData.DeletePatient(PatientID);
        }

        private bool _AddNewPatient()
        {
            //call DataAccess Layer

            this.PatientID = clsPatientsData.AddNewPatient(FirstName, LastName, Phone, Email, Address, MedicalNotes, DateOfBirth, Gendor, ImagePath);
            return (this.PatientID != -1);
        }

        private bool _UpdatePatient()
        {
            //call DataAccess Layer

            return false;

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:

                    return _UpdatePatient();
            }
            return false;
        }
    }
}
