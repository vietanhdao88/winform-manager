using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
    public class BUS_DuAn
    {
        DAL_DuAn ob = new DAL_DuAn();
		public DataTable Load()
		{
			return ob.Load();
		}
		public void ADD(DuAn ob1)
		{
			ob.ADD(ob1);
		}
		public void UPDATE(DuAn ob1)
		{
			ob.UPDATE(ob1);
		}
		public void DELETE(DuAn ob1)
		{
			ob.DELETE(ob1);
		}
		
	}
}
