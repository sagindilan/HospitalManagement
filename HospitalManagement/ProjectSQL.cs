using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HospitalManagement
{
    internal class ProjectSQL
    {
        public SqlConnection connection()
        {

            SqlConnection connect = new SqlConnection("Server=DESKTOP-J47CBIP\\SQLEXPRESS;Database=HospitalManagement;User Id=sa;Password=1;");
            connect.Open();
            return connect;
        }
    }
}
