using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.HealthFoot.Models;

namespace Web.HealthFoot.Controllers
{
    public class DirectorioController : Controller
    {

        public ActionResult List(int id)
        {

            ViewBag.UsuarioId = id;
            DirectorioModelo Directorio = new DirectorioModelo();
            ViewBag.Directorio = Directorio.findUsuario(id);
            return View();

        }

        public ActionResult Create(int idUs)
        {

            ViewBag.UsuarioId = idUs;
            return View();

        }

        public ActionResult Edit(int idUs, int id)
        {

            ViewBag.UsuarioId = idUs;
            DirectorioModelo Directorio = new DirectorioModelo();
            ViewBag.Directorio = Directorio.find(id);
            return View();

        }

        public String Delete()
        {
            return "Eliminado";
        }

        public String Update()
        {
            return "Actualizado";
        }

        public String Store()
        {
            return "Creado";
        }

    }
}