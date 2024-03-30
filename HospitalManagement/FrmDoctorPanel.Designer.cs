namespace HospitalManagement
{
    partial class FrmDoctorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtgAppointment = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RchADetails = new System.Windows.Forms.RichTextBox();
            this.Patient = new System.Windows.Forms.GroupBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnNotices = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAppointment)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Patient.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtgAppointment);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(506, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 686);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment List";
            // 
            // DtgAppointment
            // 
            this.DtgAppointment.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DtgAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgAppointment.Location = new System.Drawing.Point(3, 43);
            this.DtgAppointment.Name = "DtgAppointment";
            this.DtgAppointment.RowHeadersWidth = 51;
            this.DtgAppointment.RowTemplate.Height = 24;
            this.DtgAppointment.Size = new System.Drawing.Size(779, 640);
            this.DtgAppointment.TabIndex = 0;
            this.DtgAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgAppointment_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RchADetails);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Location = new System.Drawing.Point(11, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(409, 283);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Details";
            // 
            // RchADetails
            // 
            this.RchADetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RchADetails.Location = new System.Drawing.Point(2, 42);
            this.RchADetails.Name = "RchADetails";
            this.RchADetails.Size = new System.Drawing.Size(405, 239);
            this.RchADetails.TabIndex = 7;
            this.RchADetails.Text = "";
            // 
            // Patient
            // 
            this.Patient.Controls.Add(this.LblName);
            this.Patient.Controls.Add(this.LblTC);
            this.Patient.Controls.Add(this.label2);
            this.Patient.Controls.Add(this.label1);
            this.Patient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Patient.Location = new System.Drawing.Point(11, 11);
            this.Patient.Margin = new System.Windows.Forms.Padding(2);
            this.Patient.Name = "Patient";
            this.Patient.Padding = new System.Windows.Forms.Padding(2);
            this.Patient.Size = new System.Drawing.Size(409, 195);
            this.Patient.TabIndex = 4;
            this.Patient.TabStop = false;
            this.Patient.Text = "Doctor Information";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(158, 142);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(66, 31);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "lable";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTC.Location = new System.Drawing.Point(158, 79);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(66, 31);
            this.LblTC.TabIndex = 2;
            this.LblTC.Text = "lable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnExit);
            this.groupBox3.Controls.Add(this.BtnNotices);
            this.groupBox3.Controls.Add(this.BtnEdit);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox3.Location = new System.Drawing.Point(13, 512);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(409, 195);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quick Links";
            // 
            // BtnExit
            // 
            this.BtnExit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnExit.Location = new System.Drawing.Point(18, 131);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(371, 46);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnNotices
            // 
            this.BtnNotices.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnNotices.Location = new System.Drawing.Point(209, 67);
            this.BtnNotices.Name = "BtnNotices";
            this.BtnNotices.Size = new System.Drawing.Size(180, 46);
            this.BtnNotices.TabIndex = 1;
            this.BtnNotices.Text = "Notices";
            this.BtnNotices.UseVisualStyleBackColor = true;
            this.BtnNotices.Click += new System.EventHandler(this.BtnNotices_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnEdit.Location = new System.Drawing.Point(18, 67);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(173, 46);
            this.BtnEdit.TabIndex = 0;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // FrmDoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1303, 718);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Patient);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDoctorPanel";
            this.Text = "Doctor Panel";
            this.Load += new System.EventHandler(this.FrmDoctorPanel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgAppointment)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.Patient.ResumeLayout(false);
            this.Patient.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DtgAppointment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RchADetails;
        private System.Windows.Forms.GroupBox Patient;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnNotices;
        private System.Windows.Forms.Button BtnEdit;
    }
}