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
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }

        ProjectSQL cnt = new ProjectSQL();
        private void button2_Click(object sender, EventArgs e)
        {
            FrmPatientSingUp frm = new FrmPatientSingUp();
            frm.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * From Tbl_Patient WHERE PatientTC=@p1 and PatientPassword=@p2", cnt.connection());
            command.Parameters.AddWithValue("@p1",MskTC.Text);
            command.Parameters.AddWithValue("@p2",TxtPassword.Text);
            SqlDataReader sdr = command.ExecuteReader();
            if (sdr.Read())
            {
                FrmPatientPanel frm = new FrmPatientPanel();
                frm.TC=MskTC.Text; 
                frm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Your login information is incorrect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cnt.connection().Close();
        }

        private void FrmPatientLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
