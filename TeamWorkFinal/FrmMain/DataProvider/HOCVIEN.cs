using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FrmMain.DataProvider
{
    class HOCVIEN
    {
        SqlConnection conn;

        public HOCVIEN()
        {
            conn = new SqlConnection(@"Server=ROOT\SQLEXPRESS;Database=QLHocVien; Integrated Security=SSPI");
        }

        public DataTable SelectAll()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HocVien_Select";

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            return dt;
        }
    }
}
