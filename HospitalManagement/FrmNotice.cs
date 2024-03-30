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
    public partial class FrmNotice : Form
    {
        public FrmNotice()
        {
            InitializeComponent();
        }
        ProjectSQL cnt = new ProjectSQL();

        private void FrmNotice_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Notice", cnt.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
