namespace HospitalManagement
{
    partial class FrmSecretaryPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretaryPanel));
            this.Patient = new System.Windows.Forms.GroupBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RchNotice = new System.Windows.Forms.RichTextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ChkStatus = new System.Windows.Forms.CheckBox();
            this.CmbDoctor = new System.Windows.Forms.ComboBox();
            this.CmbBranch = new System.Windows.Forms.ComboBox();
            this.CmbTC = new System.Windows.Forms.MaskedTextBox();
            this.MskTime = new System.Windows.Forms.MaskedTextBox();
            this.MskDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAppointmentList = new System.Windows.Forms.Button();
            this.BtnBranchPanel = new System.Windows.Forms.Button();
            this.BtnDoctorPanel = new System.Windows.Forms.Button();
            this.Patient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Patient
            // 
            this.Patient.Controls.Add(this.LblName);
            this.Patient.Controls.Add(this.LblTC);
            this.Patient.Controls.Add(this.label2);
            this.Patient.Controls.Add(this.label1);
            this.Patient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Patient.Location = new System.Drawing.Point(18, 26);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(421, 194);
            this.Patient.TabIndex = 5;
            this.Patient.TabStop = false;
            this.Patient.Text = "Secretary Information";
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
            this.label2.Location = new System.Drawing.Point(51, 142);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RchNotice);
            this.groupBox1.Controls.Add(this.BtnCreate);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(12, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 348);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Notice";
            // 
            // RchNotice
            // 
            this.RchNotice.Location = new System.Drawing.Point(0, 46);
            this.RchNotice.Name = "RchNotice";
            this.RchNotice.Size = new System.Drawing.Size(409, 241);
            this.RchNotice.TabIndex = 2;
            this.RchNotice.Text = "";
            // 
            // BtnCreate
            // 
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnCreate.Location = new System.Drawing.Point(121, 293);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(183, 49);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.ChkStatus);
            this.groupBox2.Controls.Add(this.CmbDoctor);
            this.groupBox2.Controls.Add(this.CmbBranch);
            this.groupBox2.Controls.Add(this.CmbTC);
            this.groupBox2.Controls.Add(this.MskTime);
            this.groupBox2.Controls.Add(this.MskDate);
            this.groupBox2.Controls.Add(this.TxtId);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Location = new System.Drawing.Point(465, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 567);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Panel";
            // 
            // BtnSave
            // 
            this.BtnSave.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnSave.Location = new System.Drawing.Point(72, 498);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(193, 48);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ChkStatus
            // 
            this.ChkStatus.AutoSize = true;
            this.ChkStatus.Location = new System.Drawing.Point(124, 447);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.Size = new System.Drawing.Size(127, 45);
            this.ChkStatus.TabIndex = 12;
            this.ChkStatus.Text = "Status";
            this.ChkStatus.UseVisualStyleBackColor = true;
            // 
            // CmbDoctor
            // 
            this.CmbDoctor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDoctor.FormattingEnabled = true;
            this.CmbDoctor.Location = new System.Drawing.Point(127, 325);
            this.CmbDoctor.Name = "CmbDoctor";
            this.CmbDoctor.Size = new System.Drawing.Size(179, 39);
            this.CmbDoctor.TabIndex = 11;
            // 
            // CmbBranch
            // 
            this.CmbBranch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.Location = new System.Drawing.Point(124, 265);
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.Size = new System.Drawing.Size(179, 39);
            this.CmbBranch.TabIndex = 10;
            this.CmbBranch.SelectedIndexChanged += new System.EventHandler(this.CmbBranch_SelectedIndexChanged);
            // 
            // CmbTC
            // 
            this.CmbTC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTC.ForeColor = System.Drawing.Color.Teal;
            this.CmbTC.Location = new System.Drawing.Point(124, 391);
            this.CmbTC.Mask = "00000000000";
            this.CmbTC.Name = "CmbTC";
            this.CmbTC.Size = new System.Drawing.Size(179, 38);
            this.CmbTC.TabIndex = 9;
            // 
            // MskTime
            // 
            this.MskTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MskTime.Location = new System.Drawing.Point(127, 201);
            this.MskTime.Mask = "00:00";
            this.MskTime.Name = "MskTime";
            this.MskTime.Size = new System.Drawing.Size(179, 38);
            this.MskTime.TabIndex = 8;
            this.MskTime.ValidatingType = typeof(System.DateTime);
            // 
            // MskDate
            // 
            this.MskDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MskDate.Location = new System.Drawing.Point(124, 142);
            this.MskDate.Mask = "00/00/0000";
            this.MskDate.Name = "MskDate";
            this.MskDate.Size = new System.Drawing.Size(179, 38);
            this.MskDate.TabIndex = 7;
            this.MskDate.ValidatingType = typeof(System.DateTime);
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(124, 76);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(179, 38);
            this.TxtId.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "TC :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "Doctor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Branch :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Teal;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox3.Location = new System.Drawing.Point(809, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 348);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Branchs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(337, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox4.Location = new System.Drawing.Point(809, 391);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 337);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(327, 291);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.BtnAppointmentList);
            this.groupBox5.Controls.Add(this.BtnBranchPanel);
            this.groupBox5.Controls.Add(this.BtnDoctorPanel);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox5.Location = new System.Drawing.Point(12, 599);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(791, 130);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Quick Links";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(624, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Notice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAppointmentList
            // 
            this.BtnAppointmentList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnAppointmentList.Location = new System.Drawing.Point(385, 55);
            this.BtnAppointmentList.Name = "BtnAppointmentList";
            this.BtnAppointmentList.Size = new System.Drawing.Size(233, 53);
            this.BtnAppointmentList.TabIndex = 2;
            this.BtnAppointmentList.Text = "Appointment List";
            this.BtnAppointmentList.UseVisualStyleBackColor = true;
            this.BtnAppointmentList.Click += new System.EventHandler(this.BtnAppointmentList_Click);
            // 
            // BtnBranchPanel
            // 
            this.BtnBranchPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnBranchPanel.Location = new System.Drawing.Point(198, 55);
            this.BtnBranchPanel.Name = "BtnBranchPanel";
            this.BtnBranchPanel.Size = new System.Drawing.Size(181, 53);
            this.BtnBranchPanel.TabIndex = 1;
            this.BtnBranchPanel.Text = "Branch Panel";
            this.BtnBranchPanel.UseVisualStyleBackColor = true;
            this.BtnBranchPanel.Click += new System.EventHandler(this.BtnBranchPanel_Click);
            // 
            // BtnDoctorPanel
            // 
            this.BtnDoctorPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnDoctorPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnDoctorPanel.Location = new System.Drawing.Point(6, 55);
            this.BtnDoctorPanel.Name = "BtnDoctorPanel";
            this.BtnDoctorPanel.Size = new System.Drawing.Size(186, 53);
            this.BtnDoctorPanel.TabIndex = 0;
            this.BtnDoctorPanel.Text = "Doctor Panel";
            this.BtnDoctorPanel.UseVisualStyleBackColor = true;
            this.BtnDoctorPanel.Click += new System.EventHandler(this.BtnDoctorPanel_Click);
            // 
            // FrmSecretaryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1164, 741);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Patient);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmSecretaryPanel";
            this.Text = "Secretary Panel";
            this.Load += new System.EventHandler(this.FrmSecretaryPanel_Load);
            this.Patient.ResumeLayout(false);
            this.Patient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Patient;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.CheckBox ChkStatus;
        private System.Windows.Forms.ComboBox CmbDoctor;
        private System.Windows.Forms.ComboBox CmbBranch;
        private System.Windows.Forms.MaskedTextBox CmbTC;
        private System.Windows.Forms.MaskedTextBox MskTime;
        private System.Windows.Forms.MaskedTextBox MskDate;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnAppointmentList;
        private System.Windows.Forms.Button BtnDoctorPanel;
        private System.Windows.Forms.RichTextBox RchNotice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnBranchPanel;
    }
}