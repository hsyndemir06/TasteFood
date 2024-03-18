using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteFood.Entities
{
	public class Chef
	{
		public int ChefID { get; set; }
		public string ChefDescription { get; set; }
		public string ChefImageUrl { get; set; }
		public string ChefTitle { get; set; }
		public string ChefNameSurname { get; set; }
	}
}