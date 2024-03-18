using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteFood.Entities
{
    public class Urunler
    {
		[Key]
		public int UrdunID { get; set; }
		public string UrunName { get; set; }
		public string UruntDescription { get; set; }
		public decimal UrunPrice { get; set; }
		public string UrunImageUrl { get; set; }
		public bool UrunIsActive { get; set; }
	}
}