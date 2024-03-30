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
using System.Xml;

namespace HospitalManagement
{
    public partial class FrmDoctorLogin : Form
    {
        public FrmDoctorLogin()
        {
            InitializeComponent();
        }

        ProjectSQL cnt = new ProjectSQL();
        private void FrmDoctorLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnDoctorLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Doctor WHERE DoctorTC=@p1 and DoctorPassword=@p2", cnt.connection());
            cmd.Parameters.AddWithValue("@p1",MskTC.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmDoctorPanel frm= new FrmDoctorPanel();
                frm.TC= MskTC.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Your login information is incorrect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cnt.connection().Close();   
        }
    }
}
