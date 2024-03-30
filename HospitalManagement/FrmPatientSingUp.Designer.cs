namespace HospitalManagement
{
    partial class FrmPatientSingUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientSingUp));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.MskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(73, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(161, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(113, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surname :  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(158, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 45);
            this.label4.TabIndex = 2;
            this.label4.Text = "TC No : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 45);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Number : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(110, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 45);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(145, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 45);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender :";
            // 
            // MskTC
            // 
            this.MskTC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MskTC.Location = new System.Drawing.Point(308, 374);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(251, 51);
            this.MskTC.TabIndex = 3;
            // 
            // MskPhoneNumber
            // 
            this.MskPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MskPhoneNumber.Location = new System.Drawing.Point(308, 452);
            this.MskPhoneNumber.Mask = "(999) 000-0000";
            this.MskPhoneNumber.Name = "MskPhoneNumber";
            this.MskPhoneNumber.Size = new System.Drawing.Size(251, 51);
            this.MskPhoneNumber.TabIndex = 4;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(308, 302);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(251, 51);
            this.TxtSurname.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(308, 230);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(251, 51);
            this.TxtName.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(308, 535);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(251, 51);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CmbGender.Location = new System.Drawing.Point(308, 614);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(251, 53);
            this.CmbGender.TabIndex = 6;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.ForeColor = System.Drawing.Color.Teal;
            this.BtnSignUp.Location = new System.Drawing.Point(334, 692);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(176, 65);
            this.BtnSignUp.TabIndex = 13;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // FrmPatientSingUp
            // 
            this.AcceptButton = this.BtnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(694, 792);
            this.Controls.Add(this.BtnSignUp);
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
            this.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "FrmPatientSingUp";
            this.Text = "Patient Sing Up";
            this.Load += new System.EventHandler(this.FrmPatientSingUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.MaskedTextBox MskPhoneNumber;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.Button BtnSignUp;
    }
}