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
    public partial class FrmPatientSingUp : Form
    {
        public FrmPatientSingUp()
        {
            InitializeComponent();
        }
        
        ProjectSQL cnt = new ProjectSQL();
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Tbl_Patient (PatientName,PatientSurname,PatientTC,PatientPhone,PatientPassword,PatientGender) values (@p1,@p2,@p3,@p4,@p5,@p6)",cnt.connection() );
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2",TxtSurname.Text);
            command.Parameters.AddWithValue("@p3", MskTC.Text);
            command.Parameters.AddWithValue("@p4", MskPhoneNumber.Text);
            command.Parameters.AddWithValue("@p5", TxtPassword.Text);
            command.Parameters.AddWithValue("@p6", CmbGender.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Your registration has been completed.", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void FrmPatientSingUp_Load(object sender, EventArgs e)
        {

        }
    }
}
