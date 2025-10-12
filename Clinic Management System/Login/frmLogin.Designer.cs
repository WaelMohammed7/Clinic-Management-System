namespace Clinic_Management_System
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.buLogin = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassowrd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.Location = new System.Drawing.Point(386, 51);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 19);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "إنشاء حساب";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.chkRememberMe);
            this.guna2GradientPanel1.Controls.Add(this.buLogin);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.txtPassowrd);
            this.guna2GradientPanel1.Controls.Add(this.txtUserName);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(31, 89);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(430, 303);
            this.guna2GradientPanel1.TabIndex = 4;
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.BackColor = System.Drawing.Color.White;
            this.chkRememberMe.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.chkRememberMe.Location = new System.Drawing.Point(320, 209);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkRememberMe.Size = new System.Drawing.Size(70, 23);
            this.chkRememberMe.TabIndex = 2;
            this.chkRememberMe.Text = "تذكرني";
            this.chkRememberMe.UseVisualStyleBackColor = false;
            this.chkRememberMe.CheckedChanged += new System.EventHandler(this.chkRememberMe_CheckedChanged);
            // 
            // buLogin
            // 
            this.buLogin.AutoRoundedCorners = true;
            this.buLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(184)))));
            this.buLogin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buLogin.ForeColor = System.Drawing.Color.White;
            this.buLogin.Location = new System.Drawing.Point(160, 237);
            this.buLogin.Name = "buLogin";
            this.buLogin.Size = new System.Drawing.Size(122, 38);
            this.buLogin.TabIndex = 3;
            this.buLogin.Text = "Login";
            this.buLogin.Click += new System.EventHandler(this.buLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(205, 30);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "تسجيل الدخول";
            // 
            // txtPassowrd
            // 
            this.txtPassowrd.AutoRoundedCorners = true;
            this.txtPassowrd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassowrd.DefaultText = "";
            this.txtPassowrd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassowrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassowrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassowrd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassowrd.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassowrd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassowrd.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.txtPassowrd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassowrd.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtPassowrd.Location = new System.Drawing.Point(44, 144);
            this.txtPassowrd.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPassowrd.Name = "txtPassowrd";
            this.txtPassowrd.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassowrd.PlaceholderText = "Passowrd";
            this.txtPassowrd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassowrd.SelectedText = "";
            this.txtPassowrd.Size = new System.Drawing.Size(351, 40);
            this.txtPassowrd.TabIndex = 1;
            this.txtPassowrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPassowrd.TextChanged += new System.EventHandler(this.txtPassowrd_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.AutoRoundedCorners = true;
            this.txtUserName.BackColor = System.Drawing.Color.Teal;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.txtUserName.ForeColor = System.Drawing.Color.Teal;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtUserName.Location = new System.Drawing.Point(44, 76);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "Name User";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(351, 40);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(236, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "CMS";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(487, 414);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMS";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private Guna.UI2.WinForms.Guna2Button buLogin;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPassowrd;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private System.Windows.Forms.Label label1;
    }
}

