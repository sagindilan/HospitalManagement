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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }

        ProjectSQL cnt = new ProjectSQL();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * From Tbl_Secretary WHERE SecretaryTC=@p1 and SecretaryPassword=@p2",cnt.connection());
            command.Parameters.AddWithValue("@p1",MskTC.Text);
            command.Parameters.AddWithValue("@p2",TxtPassword.Text);
            SqlDataReader sdr = command.ExecuteReader();
            if (sdr.Read())
            {
                FrmSecretaryPanel frm = new FrmSecretaryPanel();
                frm.TC = MskTC.Text;
                frm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Your login information is incorrect.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cnt.connection().Close();
        }
    }
}
