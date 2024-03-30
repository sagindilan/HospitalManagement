namespace HospitalManagement
{
    partial class FrmPatientUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientUpdate));
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.MskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUpdate.ForeColor = System.Drawing.Color.Teal;
            this.BtnUpdate.Location = new System.Drawing.Point(396, 651);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(176, 65);
            this.BtnUpdate.TabIndex = 27;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Location = new System.Drawing.Point(363, 576);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(251, 49);
            this.CmbGender.TabIndex = 6;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(363, 497);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(251, 47);
            this.TxtPassword.TabIndex = 5;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(363, 192);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(251, 47);
            this.TxtName.TabIndex = 1;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(363, 261);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(251, 47);
            this.TxtSurname.TabIndex = 2;
            // 
            // MskPhoneNumber
            // 
            this.MskPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MskPhoneNumber.Location = new System.Drawing.Point(363, 414);
            this.MskPhoneNumber.Mask = "(999) 000-0000";
            this.MskPhoneNumber.Name = "MskPhoneNumber";
            this.MskPhoneNumber.Size = new System.Drawing.Size(251, 47);
            this.MskPhoneNumber.TabIndex = 4;
            // 
            // MskTC
            // 
            this.MskTC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MskTC.Location = new System.Drawing.Point(363, 336);
            this.MskTC.Mask = "0000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(251, 47);
            this.MskTC.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(200, 576);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 41);
            this.label7.TabIndex = 20;
            this.label7.Text = "Gender :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(67, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 41);
            this.label5.TabIndex = 19;
            this.label5.Text = "Phone Number : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(165, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 41);
            this.label6.TabIndex = 18;
            this.label6.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(168, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 41);
            this.label3.TabIndex = 17;
            this.label3.Text = "Surname :  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(213, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 41);
            this.label4.TabIndex = 16;
            this.label4.Text = "TC No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(216, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 41);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(128, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 81);
            this.label1.TabIndex = 14;
            this.label1.Text = "Patient Registration";
            // 
            // FrmPatientUpdate
            // 
            this.AcceptButton = this.BtnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(769, 751);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.MskPhoneNumber);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "FrmPatientUpdate";
            this.Text = "Patient Information Update";
            this.Load += new System.EventHandler(this.FrmPatientUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.MaskedTextBox MskPhoneNumber;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}