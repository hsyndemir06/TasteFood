using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteFood.Entities
{
	public class OpenDayHour
	{
		public int OpenDayHourID { get; set; }

		[StringLength(9)]
		[Required]
		public string OpenDayHourDayName { get; set; }

		[StringLength(20)]
		public string OpenHourRange { get; set; }
	}
}