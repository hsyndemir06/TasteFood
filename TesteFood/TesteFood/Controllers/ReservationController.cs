using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFood.Context;
using TesteFood.Entities;

namespace TesteFood.Controllers
{
    public class ReservationController : Controller
    {
        TasteContext context = new TasteContext();


        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialReservation()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialReservation(Reservation p)
        {
            var value = context.Reservations.Add(p);
            value.ReservationName = p.ReservationName;
            value.ReservationEmail = p.ReservationEmail;
            value.ReservationPhone = p.ReservationPhone;
            value.ReservationDate = p.ReservationDate;
            value.ReservationTime = p.ReservationTime;
            value.ReservationGuest = p.ReservationGuest;
            //value.ReservationGuest = 1;
            value.ReservationStatus = "Çalışan";
            context.SaveChanges();
            return PartialView(value);
        }

        [HttpGet]
        public PartialViewResult PartialAddReservation()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddReservation(Reservation p)
        {
            var value = context.Reservations.Add(p);
            value.ReservationName = p.ReservationName;
            value.ReservationEmail = p.ReservationEmail;
            value.ReservationPhone = p.ReservationPhone;
            value.ReservationDate = p.ReservationDate;
            value.ReservationTime = p.ReservationTime;
            value.ReservationGuest = p.ReservationGuest;
            //value.ReservationGuest = 1;
            value.ReservationStatus = "Çalışan";
            context.SaveChanges();
           
            return PartialView("Index","Default");
        }

        public ActionResult ReservationList()
        {
            var values = context.Reservations.ToList();
            return View(values);
        }

        public ActionResult ReservationAktif(int id)
        {
            var values = context.Reservations.Find(id);
            values.ReservationStatus = "Aktif";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult ReservationPasif(int id)
        {
            var values = context.Reservations.Find(id);
            values.ReservationStatus = "Pasif";
            context.SaveChanges();
            return RedirectToAction("ReservationList");

        }
    }
}