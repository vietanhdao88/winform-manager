﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
	public class DAL_DonVi : Connection
	{
		public DataTable Load()
		{
			return Load("select * from DonVi");
		}
	}
}
