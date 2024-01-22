using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class Donvi
	{
		public string madv {  get; set; }
		public string tendv {  get; set; }
		public string dienthoai { get; set; }
		public Donvi() { }
		public Donvi(string madv, string tendv, string dienthoai)
		{
			this.madv = madv;
			this.tendv = tendv;
			this.dienthoai = dienthoai;
		}
	}
}
