using ClientFeatures.Models;
using System;
using System.Web.Mvc;

namespace ClientFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult MakeBooking()
        {
            return View(new Appointment
            {
                ClientName = "Adam",
                TermsAccepted = true
            });
        }

        [HttpPost]
        public JsonResult MakeBooking(Appointment appt)
        {
            // инструкции для хранения нового Appointment
            // будут идти здесь в реальном проекте
            return Json(appt, JsonRequestBehavior.AllowGet);
        }
    }
}