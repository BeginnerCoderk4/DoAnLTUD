using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class connectDB
    {
        private static string stringCN = @"Data Source=HARRY_STAN;Initial Catalog=QLXuatNhapHang;Integrated Security=True";
        public SqlConnection conn = new SqlConnection();

        public connectDB()
        {
            try
            {
                conn.ConnectionString = stringCN;
                conn.Open();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
