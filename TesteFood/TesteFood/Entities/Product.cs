using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteFood.Entities
{
	public class Product
	{
		
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public string ProductDescription { get; set; }
		public decimal ProductPrice { get; set; }
		public string ProductImageUrl { get; set; }
		public bool ProductIsActive { get; set; }

		//iliski
		public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}