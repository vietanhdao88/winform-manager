using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
namespace BUS
{
	public class BUS_DonVi
	{
		DAL_DonVi ob = new DAL_DonVi();
		public DataTable Load()
		{
			return ob.Load();
		}
	}
}
