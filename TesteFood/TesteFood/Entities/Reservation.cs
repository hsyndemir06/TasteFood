using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteFood.Entities
{
	public class Reservation
	{
		public int ReservationID { get; set; }
		public string ReservationName { get; set; }
		public string ReservationEmail { get; set; }
		public string ReservationPhone { get; set; }
		public DateTime ReservationDate { get; set; }
		public string ReservationTime { get; set; }
		public byte ReservationGuest { get; set; }
		public string ReservationStatus { get; set; }
	}
}