using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteFood.Entities
{
    public class Notifacation
    {
        public int NotifacationID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public string NotifacationIcon { get; set; }
        public string IconCircleColor { get; set; }
    }
}