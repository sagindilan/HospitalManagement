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
using System.CodeDom;

namespace HospitalManagement
{
    public partial class FrmPatientPanel : Form
    {
        public FrmPatientPanel()
        {
            InitializeComponent();
        }

        public string TC;

        ProjectSQL cnt = new ProjectSQL();
        private void FrmPatientPanel_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;

            //Pull the Name and Surname 
            SqlCommand command = new SqlCommand("SELECT PatientName,PatientSurname From Tbl_Patient WHERE PatientTC=@p1",cnt.connection());
            command.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                LblName.Text = sdr[0] + " " + sdr[1];
            }
           cnt.connection().Close();

            // Pull the Appointment History   
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tbl_Appointment WHERE AppointmentPatientTC="+TC,cnt.connection());
            sda.Fill(dt); //DataAdapter'ın içini doldur.
            dataGridView1.DataSource = dt;

            //Pull the Branch 

            SqlCommand command2 = new SqlCommand("SELECT BranchName FROM Tbl_Branch",cnt.connection());
            SqlDataReader sdr2 = command2.ExecuteReader();
            while (sdr2.Read())
            {

                CmbBranch.Items.Add(sdr2[0]);
            }
            cnt.connection().Close();

            // Pull the Doctor  


        }

        private void CmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();
            SqlCommand command3 = new SqlCommand("SELECT DoctorName,DoctorSurname From Tbl_Doctor WHERE DoctorBranch = @p1", cnt.connection());
            command3.Parameters.AddWithValue("@p1", CmbBranch.Text);
            SqlDataReader sdr3 = command3.ExecuteReader();
            while (sdr3.Read())
            {
                CmbDoctor.Items.Add(sdr3[0] + " " + sdr3[1]);
            }
            cnt.connection().Close();

        }

        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Appointment WHERE AppointmentBranch='" + CmbBranch.Text + "'" + " and AppointmentDoctor='"+CmbDoctor.Text+"'and AppointmentStatus=0",cnt.connection());
            da.Fill(dt);
            dataGridView2.DataSource= dt;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmPatientUpdate frm = new FrmPatientUpdate();
            frm.TCNo = LblTC.Text;
            frm.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView2.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView2.Rows[select].Cells[0].Value.ToString(); 
        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_Appointment SET AppointmentStatus=1,AppointmentPatientTC=@p1,AppointmentComplaint=@p2 WHERE AppointmentId=@p3",cnt.connection());
            cmd.Parameters.AddWithValue("@p1",LblTC.Text);
            cmd.Parameters.AddWithValue("@p2",RchComplaint.Text);
            cmd.Parameters.AddWithValue("@p3", TxtId.Text);
            cmd.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Your appoitment has been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
