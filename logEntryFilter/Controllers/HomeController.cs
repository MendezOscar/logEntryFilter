using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using logEntryFilter.Models;

namespace logEntryFilter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            return View(new RegisterModel());
        }
        [Register]
        [HttpPost]

        public ActionResult Register(RegisterModel modelo)
        {
            if (modelo.Password != modelo.ConfirmPassword)
                throw new Exception("Contraseñas No coinciden");

            return View(modelo);

        }
    }
}