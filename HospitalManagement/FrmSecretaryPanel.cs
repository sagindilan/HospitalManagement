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
    public partial class FrmSecretaryPanel : Form
    {
        public FrmSecretaryPanel()
        {
            InitializeComponent();
        }

        public string TC;
        ProjectSQL cnt = new ProjectSQL();
        private void FrmSecretaryPanel_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;
            SqlCommand cmd = new SqlCommand("SELECT SecretaryName,SecretarySurname From Tbl_Secretary WHERE SecretaryTC=@p1",cnt.connection());
            cmd.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader sdr1 = cmd.ExecuteReader();
            while (sdr1.Read())
            {
                LblName.Text = sdr1[0] + " " + sdr1[1];

            }
            cnt.connection().Close();

            //Transferring Branches

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT BranchName From Tbl_Branch",cnt.connection());
            da.Fill(dt); //Data Adapter'ı doldur.
            dataGridView1.DataSource = dt;

            //Importing doctors into the list
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT (DoctorName + ' ' + DoctorSurname) as 'Doctors', DoctorBranch FROM Tbl_Doctor", cnt.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            ////Transfer the branch to combobax

            SqlCommand cmd2 = new SqlCommand("SELECT BranchName FROM Tbl_Branch",cnt.connection());
            SqlDataReader sdr2 = cmd2.ExecuteReader();
            while (sdr2.Read())
            {
                CmbBranch.Items.Add(sdr2[0]);
            }
            cnt.connection().Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmdsave = new SqlCommand("INSERT INTO Tbl_Appointment (AppointmentDate,AppointmentTime,AppointmentBranch,AppointmentDoctor) values (@p1,@p2,@p3,@p4)", cnt.connection());
            cmdsave.Parameters.AddWithValue("@p1",MskDate.Text);
            cmdsave.Parameters.AddWithValue("@p2",MskTime.Text);
            cmdsave.Parameters.AddWithValue("@p3",CmbBranch.Text);
            cmdsave.Parameters.AddWithValue("@p4",CmbDoctor.Text);
            cmdsave.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Your appointment has been created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT DoctorName,DoctorSurname FROM Tbl_Doctor WHERE DoctorBranch=@p1",cnt.connection());
            cmd.Parameters.AddWithValue("@p1",CmbBranch.Text);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read()) 
            {
                CmbDoctor.Items.Add(sdr[0] +" "+ sdr[1]);
            }
            cnt.connection() .Close(); 
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Notice (Notice) values (@p1)", cnt.connection());
            cmd.Parameters.AddWithValue("@p1",RchNotice.Text);
            cmd.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Your notice has been created.","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDoctorPanel_Click(object sender, EventArgs e)
        {
            FrmAddDoctor frm = new  FrmAddDoctor();
            frm.Show();
        }

        private void BtnBranchPanel_Click(object sender, EventArgs e)
        {
            FrmAddBranch frm = new FrmAddBranch();
            frm.Show();
        }

        private void BtnAppointmentList_Click(object sender, EventArgs e)
        {
            FrmAppointmentList frm = new FrmAppointmentList();  
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNotice frm = new FrmNotice();   
            frm.Show();
        }
    }
}
