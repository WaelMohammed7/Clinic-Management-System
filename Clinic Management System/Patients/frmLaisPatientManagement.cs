using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic_Management_System.Patients;
using ClinicManagementSystemAcesseBussin;

namespace Clinic_Management_System
{
    public partial class frmLaisPatientManagement : Form
    {
        private static DataTable _dtAllPatients = clsPatients.GetAllPatients();

        private DataTable _dtPatients = _dtAllPatients.DefaultView.ToTable(false, "PatientID", "FirstName", "LastName", "Phone", "Email", "Address", "MedicalNotes");

        public frmLaisPatientManagement()
        {
            InitializeComponent();
        }

        private void _RefreshPeoplList()
        {
            _dtAllPatients = clsPatients.GetAllPatients();
            _dtPatients = _dtAllPatients.DefaultView.ToTable(false, "PatientID", "FirstName", "LastName", "Phone", "Email", "Address", "MedicalNotes");

            dgvPatients.DataSource = _dtPatients;
            lblRecordsCount.Text = dgvPatients.Rows.Count.ToString();
        }


        private void frmLaisPatientManagement_Load(object sender, EventArgs e)
        {
            //_RefreshPatientsList();

            dgvPatients.DataSource = _dtPatients;
          //  cbFilterBy.SelectedIndex = 1;
            lblRecordsCount.Text = dgvPatients.Rows.Count.ToString();
            if (dgvPatients.Rows.Count > 0)
            {
                dgvPatients.Columns[0].HeaderText = "Patient ID";
                dgvPatients.Columns[0].Width = 120;

                dgvPatients.Columns[1].HeaderText = "First Name";
                dgvPatients.Columns[1].Width = 120;

                dgvPatients.Columns[2].HeaderText = "Last Name";
                dgvPatients.Columns[2].Width = 120;

                dgvPatients.Columns[3].HeaderText = "Phone";
                dgvPatients.Columns[3].Width = 100;

                dgvPatients.Columns[4].HeaderText = "Email";
                dgvPatients.Columns[4].Width = 120;

                dgvPatients.Columns[5].HeaderText = "MedicalNotes";
                dgvPatients.Columns[5].Width = 120;


               


               
            }
        }

        private void lblRecordsCount_Click(object sender, EventArgs e)
        {

        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if(txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();

            }



        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilterBy.Text)
            {
                case "Patient ID":
                    FilterColumn = "PatientID";
                    break;
                case "First Name":
                    FilterColumn = "FirstName";
                    break;
                case "Last Name":
                    FilterColumn = "LastName";
                    break;
                case "Phone":
                    FilterColumn = "Phone";
                    break;
                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPatients.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvPatients.Rows.Count.ToString();
                return;
            }

            if(FilterColumn == "PatientID")
            {
                _dtPatients.DefaultView.RowFilter = String.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text);
            }
            else
            {
                _dtPatients.DefaultView.RowFilter = String.Format("[{0}] LIKE '{1}%'" , FilterColumn, txtFilterValue.Text);
            }

        }

        private void deletePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PatientID = Convert.ToInt16( dgvPatients.CurrentRow.Cells[0].Value);
            if(MessageBox.Show($"Are you sure you want to delete this patient? [{PatientID}]", "Confirm deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(clsPatients.DeletePatient(PatientID))
                {
                    MessageBox.Show("The client was successfully deleted.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("The person was not deleted because it was linked to other data.", "An error occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                _RefreshPeoplList();
            }

            frmLaisPatientManagement_Load(null, null);
        }

        private void picAddPatient_Click(object sender, EventArgs e)
        {
            frmAddUpdatePatient frm = new frmAddUpdatePatient();
            frm.Show();
            this.Close();
        }
    }
}
