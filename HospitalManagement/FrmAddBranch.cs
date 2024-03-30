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
    public partial class FrmAddBranch : Form
    {
        public FrmAddBranch()
        {
            InitializeComponent();
        }

        ProjectSQL cnt = new ProjectSQL();
        private void FrmAddBranch_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Branch", cnt.connection());
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Branch (BranchName) values (@b1)",cnt.connection());
            cmd.Parameters.AddWithValue("@b1",TxtBranchName.Text);
            cmd.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Branch information added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int slc  = dataGridView1.SelectedCells[0].RowIndex;
            TxtBranchId.Text = dataGridView1.Rows[slc].Cells[0].Value.ToString(); 
            TxtBranchName.Text = dataGridView1.Rows[slc].Cells[1].Value.ToString();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_Branch WHERE BranchId=@b1", cnt.connection());
            cmd.Parameters.AddWithValue("@b1", TxtBranchId.Text);
            cmd.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Branch information deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_Branch SET BranchName=@p1 WHERE BranchId=@p2", cnt.connection());
            cmd.Parameters.AddWithValue("@p1", TxtBranchId.Text);
            cmd.Parameters.AddWithValue("@p2", TxtBranchId.Text);
            cmd.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Branch information updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
