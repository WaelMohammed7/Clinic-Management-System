using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystemAcesseBussin;

namespace Clinic_Management_System
{
    public partial class frmUserManagement : Form
    {
        private DataTable _dtAllUsers;

        public static string FliterName = "";
        public static string Fliter = "";

        public frmUserManagement()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvUsers.DataSource = clsUser.GetAllUserManagement();
            blRecordsCount.Text = dgvUsers.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;

            if (dgvUsers.RowCount > 0)
            {
                dgvUsers.Columns[0].HeaderText = "ID";
                dgvUsers.Columns[0].Width = 100;

                dgvUsers.Columns[1].HeaderText = "User Name";
                dgvUsers.Columns[1].Width = 200;


                dgvUsers.Columns[2].HeaderText = "IsActive";
                dgvUsers.Columns[2].Width = 100;

            }
           
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {

            LoadData();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
           //     cbRole.Visible = true;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
                return;
            }

            else
            {
                txtFilterValue.Visible = cbFilterBy.Text != ("Noet");

                cbIsActive.Visible = false;
                if (cbFilterBy.Text == "Noet")
                {
                    txtFilterValue.Enabled = false;
                    LoadData();
                }
                else
                txtFilterValue.Enabled = true;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                //cbRole.Visible = true;
                //cbRole.Focus();
                //cbRole.SelectedIndex = 0;
            }
            else
            {
                txtFilterValue.Visible = (cbFilterBy.Text != "Noet");
              //  cbRole.Visible = false;
                if (cbFilterBy.Text == "Noet")
                {
                    txtFilterValue.Enabled = false;
                    //frmListUser_Load(null, null);
                    LoadData();
                }
                else
                    txtFilterValue.Enabled = true;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();

                if (cbFilterBy.Text == "Is Active")
                {
                    txtFilterValue.Visible = false;
                    cbIsActive.Visible = true;
                    cbIsActive.Focus();
                    cbIsActive.SelectedIndex = 0;
                }
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
            {
                case "User":
                    FilterValue = "1";
                    break;

                case "Not User":
                    FilterValue = "0";
                    break;
            }

            _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            blRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            



            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "UserID":
                    FilterColumn = "User ID";
                    break;

                case "User Name":
                    FilterColumn = "UserName";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" | FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                blRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "UserName")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            //dgvUsers.DataSource = _dtAllUsers;
            blRecordsCount.Text = dgvUsers.Rows.Count.ToString();
        }

        private void gbutClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
