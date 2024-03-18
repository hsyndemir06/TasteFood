using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteFood.Entities
{
    public class TblUrun
    {
		[Key]
		public int TblUrdunID { get; set; }
		public string TblUrunName { get; set; }
		public string TblUruntDescription { get; set; }
		public decimal TblUrunPrice { get; set; }
		public string TblUrunImageUrl { get; set; }
		public bool TblUrunIsActive { get; set; }
	}
}