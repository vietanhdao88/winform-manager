using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DuAn
	{
		public string mada { get; set; }
		public string tenda {  get; set; }
		public DateTime ngaybd { get; set; }
		public DateTime thoigian {  get; set; }
		public string dvi { get; set; }
		public int sotien {  get; set; }
		public int chiphi { get; set; }
		public string trangthai {  get; set; }
		public DuAn() { }
		public DuAn(string mada, string tenda, DateTime ngaybd, DateTime thoigian, string dvi, int sotien, int chiphi, string trangthai)
		{
			this.mada = mada;
			this.tenda = tenda;
			this.ngaybd = ngaybd;
			this.thoigian = thoigian;
			this.dvi = dvi;
			this.sotien = sotien;
			this.chiphi = chiphi;
			this.trangthai = trangthai;
		}
	}
}
