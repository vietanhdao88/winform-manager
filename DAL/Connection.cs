using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
		SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-9EGU5CS9\SQLEXPRESS;Initial Catalog=QLDA;Integrated Security=True");
		public DataTable Load(string sql)
		{
			con.Open();
			SqlDataAdapter ad = new SqlDataAdapter(sql, con);
			DataTable dt = new DataTable();
			ad.Fill(dt);
			con.Close();
			return dt;
		}
		public void Execute(string sql)
		{
			if (con.State == ConnectionState.Open) con.Close();
			con.Open();
			SqlCommand ThuchienLenh = new SqlCommand(sql, con);
			ThuchienLenh.ExecuteNonQuery();
			con.Close();
		}
	}
}
