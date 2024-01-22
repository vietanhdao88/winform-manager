using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QLDA
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			BUS_DuAn ob = new BUS_DuAn();
			dataGridView1.DataSource = ob.Load();
			BUS_DonVi ob2 = new BUS_DonVi();
			cbdonvi.DataSource = ob2.Load();
			cbdonvi.ValueMember = "MaDV";
			txtmada.Clear();
			txttenda.Clear();  
			cbdonvi.SelectedIndex = -1; 
			txtsotien.Clear(); 
			txtchiphi.Clear(); 
			txttrangthai.Clear();
		}

		private void btnadd_Click(object sender, EventArgs e)
		{
			DuAn ob = new DuAn(txtmada.Text, txttenda.Text,dtpngaybd.Value,dtpthoigian.Value, cbdonvi.SelectedValue.ToString(), int.Parse(txtsotien.Text), int.Parse(txtchiphi.Text), txttrangthai.Text);
			BUS_DuAn BUS = new BUS_DuAn();
			string targetId = txtmada.Text;

			bool idExists = false;

			// Duyệt qua từng dòng của DataGridView
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				// Kiểm tra giá trị của cột có tên là "id" (đổi tên cột tương ứng của bạn)
				if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == targetId)
				{
					// ID đã tồn tại trong DataGridView
					idExists = true;
					break; // Không cần duyệt tiếp nếu đã tìm thấy
				}
			}

			if (idExists)
			{
				// Thực hiện các hành động nếu ID đã tồn tại
				MessageBox.Show("ID đã tồn tại trong DataGridView.");
			}
			else
			{
				BUS.ADD(ob);
				// Thực hiện các hành động nếu ID chưa tồn tại
				MessageBox.Show("ID chưa tồn tại trong DataGridView.");
			}
			if(DateTime.Compare(dtpngaybd.Value , dtpthoigian.Value) > 0)
			{
				MessageBox.Show("thoi gian phai lon hon ngay bd");
				return;
				
			}
			if(DateTime.Compare(dtpngaybd.Value, dtpthoigian.Value) < 0)
			{
				BUS.ADD(ob);
			
			}

			Form1_Load(sender, e);
		}

		private void dtpngaybd_ValueChanged(object sender, EventArgs e)
		{
		
		}

		private void btnupdate_Click(object sender, EventArgs e)
		{
			DuAn ob = new DuAn(txtmada.Text, txttenda.Text, dtpngaybd.Value, dtpthoigian.Value, cbdonvi.SelectedValue.ToString(), int.Parse(txtsotien.Text), int.Parse(txtchiphi.Text), txttrangthai.Text);
			BUS_DuAn BUS = new BUS_DuAn();

			BUS.UPDATE(ob);
			Form1_Load(sender, e);
		}

		private void btn_Click(object sender, EventArgs e)
		{
			Form2 f = new Form2();
			f.Show();
		}

		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			int i = e.RowIndex;
			txtmada.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
			txttenda.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
			dtpngaybd.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
			dtpthoigian.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
			cbdonvi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
			txtsotien.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
			txtchiphi.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
			txttrangthai.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

		}

		private void btndelete_Click(object sender, EventArgs e)
		{
			DuAn ob = new DuAn(txtmada.Text, txttenda.Text, dtpngaybd.Value, dtpthoigian.Value, cbdonvi.SelectedValue.ToString(), int.Parse(txtsotien.Text), int.Parse(txtchiphi.Text), txttrangthai.Text);
			BUS_DuAn BUS = new BUS_DuAn();
			BUS.DELETE(ob);
			Form1_Load(sender, e);
		}
	}
}
