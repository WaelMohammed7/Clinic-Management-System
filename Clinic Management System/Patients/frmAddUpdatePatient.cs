using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic_Management_System.Properties;
using ClinicManagementSystemAcesseBussin;

namespace Clinic_Management_System.Patients
{
    public partial class frmAddUpdatePatient : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private int _PatientID = -1;
        private clsPatients _Patients;

        public frmAddUpdatePatient()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdatePatient(int PatientID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PatientID = PatientID;

        }

        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Patient";
                _Patients = new clsPatients();
            }
            else
            {
                lblTitle.Text = "Update Patient";
            }

            if (rbMale.Checked)
            {
                pbPatientImage.Image = Resources.Male_512;
            }
            else
            {
                pbPatientImage.Image = Resources.Female_512;
            }

            llRemoveImage.Visible = (pbPatientImage.ImageLocation != null);

            txtFirstName.Text = "";
            txtLastName.Text = "";
            rbFemale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtMedicalNotes.Text = "";
        }

        private void _LoadData()
        {
            if (_Mode != enMode.Update)
            {
                return;
            }
            else
            {

            }
        }

        private void gbutClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdatePatient_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            //if (_Mode == enMode.Update)
            //    _LoadData();
        }

        private void gbutSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _Patients.FirstName = txtFirstName.Text;
            _Patients.LastName = txtLastName.Text;
            _Patients.Phone = txtPhone.Text;
            _Patients.Email = txtEmail.Text;
            _Patients.Address = txtAddress.Text;
            _Patients.MedicalNotes = txtMedicalNotes.Text;
            _Patients.DateOfBirth = dtpDateOfBirth.Value;
            if (rbMale.Checked)
                _Patients.Gendor = 0;
            else
                _Patients.Gendor = 1;
            //_Patients.ImagePath = 

            if (_Patients.Save())
            {
                txtPatientID.Text = _Patients.PatientID.ToString();

                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Patient";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
