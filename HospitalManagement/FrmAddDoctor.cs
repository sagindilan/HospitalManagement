using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalManagement
{
    public partial class FrmAddDoctor : Form
    {
        public FrmAddDoctor()
        {
            InitializeComponent();
        }

        ProjectSQL cnt = new ProjectSQL();
        private void FrmAddDoctor_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Doctor", cnt.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand cmd2 = new SqlCommand("SELECT BranchName FROM Tbl_Branch", cnt.connection());
            SqlDataReader sdr2 = cmd2.ExecuteReader();
            while (sdr2.Read())
            {
                CmbBranch.Items.Add(sdr2[0]);
            }
            cnt.connection().Close();

    }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Doctor (DoctorName,DoctorSurname,DoctorBranch,DoctorTC,DoctorPassword) values (@p1,@p2,@p3,@p4,@p5)", cnt.connection());
            cmd.Parameters.AddWithValue("@p1",TxtName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", CmbBranch.Text);
            cmd.Parameters.AddWithValue("@p4", MskTC.Text);
            cmd.Parameters.AddWithValue("@p5", TxtPassword.Text);
            cmd.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Doctor added.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            CmbBranch.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_Doctor WHERE DoctorTC=@p1",cnt.connection());
            cmd.Parameters.AddWithValue("@p1",MskTC.Text);
            cmd.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Doctor deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_Doctor set DoctorName=@p1,DoctorSurname=@p2,DoctorBranch=@p3,DoctorPassword=@p5 WHERE DoctorTC=@p4", cnt.connection());
            cmd.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", CmbBranch.Text);
            cmd.Parameters.AddWithValue("@p4", MskTC.Text);
            cmd.Parameters.AddWithValue("@p5", TxtPassword.Text);
            cmd.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Doctor information updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
