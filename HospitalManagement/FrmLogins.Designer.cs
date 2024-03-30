namespace HospitalManagement
{
    partial class FrmLogins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogins));
            this.BtnPatientLogin = new System.Windows.Forms.Button();
            this.BtnDoctorLogin = new System.Windows.Forms.Button();
            this.BtnSecretaryLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblPatient = new System.Windows.Forms.Label();
            this.LblDoctor = new System.Windows.Forms.Label();
            this.LblSecretary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPatientLogin
            // 
            this.BtnPatientLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPatientLogin.BackgroundImage")));
            this.BtnPatientLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPatientLogin.Location = new System.Drawing.Point(61, 485);
            this.BtnPatientLogin.Name = "BtnPatientLogin";
            this.BtnPatientLogin.Size = new System.Drawing.Size(291, 191);
            this.BtnPatientLogin.TabIndex = 0;
            this.BtnPatientLogin.UseVisualStyleBackColor = true;
            this.BtnPatientLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDoctorLogin
            // 
            this.BtnDoctorLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoctorLogin.BackgroundImage")));
            this.BtnDoctorLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoctorLogin.Location = new System.Drawing.Point(460, 485);
            this.BtnDoctorLogin.Name = "BtnDoctorLogin";
            this.BtnDoctorLogin.Size = new System.Drawing.Size(267, 191);
            this.BtnDoctorLogin.TabIndex = 1;
            this.BtnDoctorLogin.UseVisualStyleBackColor = true;
            this.BtnDoctorLogin.Click += new System.EventHandler(this.BtnDoctorLogin_Click);
            // 
            // BtnSecretaryLogin
            // 
            this.BtnSecretaryLogin.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSecretaryLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSecretaryLogin.BackgroundImage")));
            this.BtnSecretaryLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSecretaryLogin.Location = new System.Drawing.Point(865, 485);
            this.BtnSecretaryLogin.Name = "BtnSecretaryLogin";
            this.BtnSecretaryLogin.Size = new System.Drawing.Size(282, 191);
            this.BtnSecretaryLogin.TabIndex = 2;
            this.BtnSecretaryLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSecretaryLogin.UseVisualStyleBackColor = false;
            this.BtnSecretaryLogin.Click += new System.EventHandler(this.BtnSecretaryLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LblPatient
            // 
            this.LblPatient.AutoSize = true;
            this.LblPatient.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatient.ForeColor = System.Drawing.SystemColors.Control;
            this.LblPatient.Location = new System.Drawing.Point(151, 690);
            this.LblPatient.Name = "LblPatient";
            this.LblPatient.Size = new System.Drawing.Size(87, 30);
            this.LblPatient.TabIndex = 4;
            this.LblPatient.Text = "Patient";
            // 
            // LblDoctor
            // 
            this.LblDoctor.AutoSize = true;
            this.LblDoctor.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDoctor.ForeColor = System.Drawing.SystemColors.Control;
            this.LblDoctor.Location = new System.Drawing.Point(557, 690);
            this.LblDoctor.Name = "LblDoctor";
            this.LblDoctor.Size = new System.Drawing.Size(84, 30);
            this.LblDoctor.TabIndex = 5;
            this.LblDoctor.Text = "Doctor";
            // 
            // LblSecretary
            // 
            this.LblSecretary.AutoSize = true;
            this.LblSecretary.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSecretary.ForeColor = System.Drawing.SystemColors.Control;
            this.LblSecretary.Location = new System.Drawing.Point(950, 683);
            this.LblSecretary.Name = "LblSecretary";
            this.LblSecretary.Size = new System.Drawing.Size(112, 30);
            this.LblSecretary.TabIndex = 6;
            this.LblSecretary.Text = "Secretary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(267, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(692, 85);
            this.label4.TabIndex = 7;
            this.label4.Text = "ACIBADEM HOSPITAL";
            // 
            // FrmLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblSecretary);
            this.Controls.Add(this.LblDoctor);
            this.Controls.Add(this.LblPatient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSecretaryLogin);
            this.Controls.Add(this.BtnDoctorLogin);
            this.Controls.Add(this.BtnPatientLogin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FrmLogins";
            this.Text = "Acıbadem Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPatientLogin;
        private System.Windows.Forms.Button BtnDoctorLogin;
        private System.Windows.Forms.Button BtnSecretaryLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblPatient;
        private System.Windows.Forms.Label LblDoctor;
        private System.Windows.Forms.Label LblSecretary;
        private System.Windows.Forms.Label label4;
    }
}

