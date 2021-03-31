using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace WebAPP1
{
    public class DAO
    {

        private SqlConnection SqlCon;

        public DAO()
        {
            SqlCon = new SqlConnection("Data Source=DESKTOP-J28G2CO;Initial Catalog=ginger_db;Integrated Security=True");
        }

        public bool UDI(string qry)
        {
            SqlCon.Open();
            SqlCommand cmd = new SqlCommand(qry, SqlCon);
            int res = cmd.ExecuteNonQuery();
            SqlCon.Close();
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable Search(string qry)
        {
            SqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(qry, SqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlCon.Close();
            if (dt.Rows.Count > 0)
            {
                return dt;
            }

            return null;
        }
    }
}



