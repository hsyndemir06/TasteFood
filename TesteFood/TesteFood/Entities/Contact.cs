using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteFood.Entities
{
	public class Contact
	{
		public int ContactID { get; set; }
		public string ContactName { get; set; }
		public string ContactEmail { get; set; }
		public string ContactSubject { get; set; }
		public string ContactMessage { get; set; }
		public DateTime ContactSendDate { get; set; }
		public bool IsRead { get; set; }
	}
}