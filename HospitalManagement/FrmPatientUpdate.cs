using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalManagement
{
    public partial class FrmPatientUpdate : Form
    {
        public FrmPatientUpdate()
        {
            InitializeComponent();
        }

        public string TCNo;

        ProjectSQL cnt = new ProjectSQL();
        private void FrmPatientUpdate_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCNo; 
            SqlCommand command = new SqlCommand("Select * From Tbl_Patient WHERE PatientTC=@p1",cnt.connection());
            command.Parameters.AddWithValue("@p1",TCNo);
            command.ExecuteNonQuery();
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read()) 
            {   
                TxtName.Text   = sdr[1].ToString();
                TxtSurname.Text = sdr[2].ToString();
                MskPhoneNumber.Text = sdr[4].ToString();
                TxtPassword.Text = sdr[5].ToString();
                CmbGender.Text = sdr[6].ToString(); 
            }
            cnt.connection().Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
         
                SqlCommand command2 = new SqlCommand("UPDATE Tbl_Patient SET PatientName=@p1,PatientSurname=@p2,PatientPhone=@p3,PatientPassword=@p4,PatientGender=@p5 WHERE PatientTC=@p6", cnt.connection());
                command2.Parameters.AddWithValue("@p1", TxtName.Text);
                command2.Parameters.AddWithValue("@p2", TxtSurname.Text);
                command2.Parameters.AddWithValue("@p3", MskPhoneNumber.Text);
                command2.Parameters.AddWithValue("@p4", TxtPassword.Text);
                command2.Parameters.AddWithValue("@p5", CmbGender.Text);
                command2.Parameters.AddWithValue("@p6", TCNo); 
                command2.ExecuteNonQuery();
                cnt.connection().Close();
                MessageBox.Show("Your information has been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
    
