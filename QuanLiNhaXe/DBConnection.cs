using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaXe
{
    internal class DBConnection
    {
        // tạo 2 biến cục bộ
        string strCon = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QuanLyNhaXe;Integrated Security=True";        // đối tượng kết nối
        SqlConnection sqlCon = null;
        public SqlConnection getConnection
        {
            get
            {
                return sqlCon;
            }
        }
        public void MoKetNoi()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }
        public void DongKetNoi()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

    }
}
