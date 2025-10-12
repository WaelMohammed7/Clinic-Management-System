using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class frmMainScreen : Form
    {
        frmLogin _login;
        public frmMainScreen(frmLogin login)
        {
            InitializeComponent();
            _login = login;
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmLaisPatientManagement frm = new frmLaisPatientManagement();
            frm.Show();
        }

        private void frmMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            _login.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmUserManagement frm = new frmUserManagement();
            frm.Show();
        }
    }
}
