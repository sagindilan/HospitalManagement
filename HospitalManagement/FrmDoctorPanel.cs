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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }

        ProjectSQL cnt = new ProjectSQL();
        public string TC;
        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
          LblTC.Text = TC;

            //Doctor Name and Surname
            SqlCommand cmd = new SqlCommand("SELECT DoctorName,DoctorSurname FROM Tbl_Doctor WHERE DoctorTC=@p1",cnt.connection());
            cmd.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               LblName.Text = dr[0] + " " + dr[1];
            }
            cnt.connection().Close();
            
            //Appointment
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Appointment WHERE AppointmentDoctor='"+LblName.Text+"'",cnt.connection());
            da.Fill(dt);
            DtgAppointment.DataSource= dt;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmDoctorUpdate frm = new FrmDoctorUpdate();
            frm.TCNo= LblTC.Text;
            frm.Show();
          
        }

        private void BtnNotices_Click(object sender, EventArgs e)
        {
            FrmNotice frm = new FrmNotice();
            frm.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void DtgAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = DtgAppointment.SelectedCells[0].RowIndex;
            RchADetails.Text = DtgAppointment.Rows[select].Cells[7].Value.ToString();
        }
    }
}
