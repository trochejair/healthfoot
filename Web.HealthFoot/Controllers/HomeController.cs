using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.HealthFoot.Controllers
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

        public ActionResult Administracion()
        {
            return View();
        }

        public ActionResult Principal()
        {
            return View();
        }

        public ActionResult InicioSesion()
        {
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }

        public ActionResult Producto()
        {
            return View();
        }

        public ActionResult ProductoDetail()
        {
            return View();
        }
    }
}