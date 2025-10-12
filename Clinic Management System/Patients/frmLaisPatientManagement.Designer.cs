namespace Clinic_Management_System
{
    partial class frmLaisPatientManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picAddPatient = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRecordsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblRecordsCount.Location = new System.Drawing.Point(106, 507);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(38, 21);
            this.lblRecordsCount.TabIndex = 49;
            this.lblRecordsCount.Text = "????";
            this.lblRecordsCount.Click += new System.EventHandler(this.lblRecordsCount_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.txtFilterValue.Location = new System.Drawing.Point(255, 96);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(177, 29);
            this.txtFilterValue.TabIndex = 51;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Patient ID",
            "First Name",
            "Last Name",
            "Phone"});
            this.cbFilterBy.Location = new System.Drawing.Point(101, 96);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(138, 29);
            this.cbFilterBy.TabIndex = 52;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatients.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatients.Location = new System.Drawing.Point(16, 134);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersWidth = 62;
            this.dgvPatients.RowTemplate.Height = 29;
            this.dgvPatients.Size = new System.Drawing.Size(1312, 357);
            this.dgvPatients.TabIndex = 53;
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPatientToolStripMenuItem,
            this.editPatientToolStripMenuItem,
            this.deletePatientToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 100);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPatientToolStripMenuItem
            // 
            this.showPatientToolStripMenuItem.Image = global::Clinic_Management_System.Properties.Resources.PersonDetails_32;
            this.showPatientToolStripMenuItem.Name = "showPatientToolStripMenuItem";
            this.showPatientToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.showPatientToolStripMenuItem.Text = "Show Patient";
            // 
            // editPatientToolStripMenuItem
            // 
            this.editPatientToolStripMenuItem.Image = global::Clinic_Management_System.Properties.Resources.edit;
            this.editPatientToolStripMenuItem.Name = "editPatientToolStripMenuItem";
            this.editPatientToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.editPatientToolStripMenuItem.Text = "Edit Patient";
            // 
            // deletePatientToolStripMenuItem
            // 
            this.deletePatientToolStripMenuItem.Image = global::Clinic_Management_System.Properties.Resources.Delete_32_2;
            this.deletePatientToolStripMenuItem.Name = "deletePatientToolStripMenuItem";
            this.deletePatientToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.deletePatientToolStripMenuItem.Text = "Delete Patient";
            this.deletePatientToolStripMenuItem.Click += new System.EventHandler(this.deletePatientToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(12, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "# Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 95;
            this.label2.Text = "Filter By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(595, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 103;
            this.label3.Text = "Manage Patient";
            // 
            // picAddPatient
            // 
            this.picAddPatient.BackColor = System.Drawing.Color.White;
            this.picAddPatient.Image = global::Clinic_Management_System.Properties.Resources.Add;
            this.picAddPatient.Location = new System.Drawing.Point(1230, 72);
            this.picAddPatient.Name = "picAddPatient";
            this.picAddPatient.Size = new System.Drawing.Size(88, 53);
            this.picAddPatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddPatient.TabIndex = 102;
            this.picAddPatient.TabStop = false;
            this.picAddPatient.Click += new System.EventHandler(this.picAddPatient_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Clinic_Management_System.Properties.Resources.Peopl;
            this.guna2PictureBox1.Location = new System.Drawing.Point(619, 13);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(111, 67);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 47;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmLaisPatientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 535);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picAddPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLaisPatientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lais Patient Management";
            this.Load += new System.EventHandler(this.frmLaisPatientManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePatientToolStripMenuItem;
        private System.Windows.Forms.PictureBox picAddPatient;
        private System.Windows.Forms.Label label3;
    }
}