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
    public partial class FrmDoctorUpdate : Form
    {
        public FrmDoctorUpdate()
        {
            InitializeComponent();
        }

        ProjectSQL  cnt = new ProjectSQL();
        public string TCNo;
        private void FrmDoctorUpdate_Load(object sender, EventArgs e)
        {
            MskTC.Text= TCNo;
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Doctor WHERE DoctorTc=@p1",cnt.connection());
            cmd.Parameters.AddWithValue("@p1",MskTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TxtName.Text = dr[1].ToString();    
                TxtSurname.Text = dr[2].ToString();
                CmbBranch.Text = dr[3].ToString();
                TxtPassword .Text = dr[5].ToString();
            }    
            cnt.connection().Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_Doctor SET DoctorName=@p1,DoctorSurname=@p2,DoctorBranch=@p3,DoctorPassword=@p4 WHERE DoctorTC=@p5",cnt.connection());
            cmd.Parameters.AddWithValue("@p1",TxtName.Text);
            cmd.Parameters.AddWithValue("@p2",TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3",CmbBranch.Text);
            cmd.Parameters.AddWithValue("@p4",TxtPassword.Text);
            cmd.Parameters.AddWithValue("@p5",MskTC.Text);
            cmd.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Your registration has been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
