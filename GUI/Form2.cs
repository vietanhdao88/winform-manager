using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace QLDA
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

            this.reportViewer1.RefreshReport();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			string sql = "select TenDA,  Ten_GD ,TenNV , DanhGia from GiaiDoanDA join DuAn on GiaiDoanDA.MaDA = DuAn.MaDA join ThamGia on DuAn.MaDA = ThamGia.MaDA join NhanVien on ThamGia.MaNV = NhanVien.MaNV";
			Connection sv = new Connection();
			DataTable dt = new DataTable();
			dt = sv.Load(sql);
			reportViewer1.ProcessingMode =
			Microsoft.Reporting.WinForms.ProcessingMode.Local;

			reportViewer1.LocalReport.ReportPath = @"C:\Users\HP\source\repos\QLDA\QLDA\Report1.rdlc";
			if (dt.Rows.Count > 0)
			{

				ReportDataSource rds = new ReportDataSource();
				rds.Name = "DataSet1";
				rds.Value = dt;

				reportViewer1.LocalReport.DataSources.Clear();

				reportViewer1.LocalReport.DataSources.Add(rds);

				reportViewer1.RefreshReport();
			}
			else MessageBox.Show("Khong co du lieu");
		
	}
	}
}
