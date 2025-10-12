using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic_Management_System.Global;
using ClinicManagementSystemAcesseBussin;

namespace Clinic_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void buLogin_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.FindUserByUserNameAndPassword(txtUserName.Text.Trim(), txtPassowrd.Text.Trim());

            if (user != null)
            {
                if (chkRememberMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassowrd.Text.Trim());
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                if (user.IsActive == 0)
                {
                    txtUserName.Focus();
                    MessageBox.Show("حسابك غير مفعل، يرجى الاتصال بالمسؤول", "حساب غير نشط", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.CurrentUser = user;
                this.Hide();
                frmMainScreen form = new frmMainScreen(this);
                form.ShowDialog();
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة", "بيانات اعتماد خاطئة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmAddUpdateUser frm = new frmAddUpdateUser();
           // frm.ShowDialog();
        }

        private void txtPassowrd_TextChanged(object sender, EventArgs e)
        {
            txtPassowrd.PasswordChar = '*';
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassowrd.Text = Password;
                chkRememberMe.Checked = true;
            }
        }
    }
}
