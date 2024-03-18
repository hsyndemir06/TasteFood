using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteFood.Entities
{
	public class Category
	{
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }


		// iliski
		public List<Product> Products { get; set; }
	}
}