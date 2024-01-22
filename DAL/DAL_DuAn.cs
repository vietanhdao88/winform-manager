using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
	public class DAL_DuAn : Connection
	{
		public DataTable Load()
		{
			return Load("select * from DuAn");
		}
		public void ADD(DuAn ob)
		{
			string sql = "insert into DuAn values ('"+ob.mada+"' , '"+ob.tenda+"' , '"+ob.ngaybd+"' , '"+ob.thoigian+"' , '"+ob.dvi+"' , '"+ob.sotien+"' , '"+ob.chiphi+"' , '"+ob.trangthai+"')";
			Execute(sql);
		}
		public void UPDATE(DuAn ob)
		{
			string sql = "update DuAn set tenda = '" + ob.tenda + "' ,ngaybd = '"+ob.ngaybd+"' , thoigian = '"+ob.thoigian+"' , donvi_ptrach = '"+ob.dvi+"' ,sotien = '"+ob.sotien+"' ,chiphi = '"+ob.chiphi+"' ,trangthai = '"+ob.trangthai+"' where mada = '"+ob.mada+"' ";
			Execute(sql);
		}
		public void DELETE(DuAn ob)
		{
			string sql = "delete from DuAn where mada = '" + ob.mada + "'";
			Execute(sql);
		}
	}
}
