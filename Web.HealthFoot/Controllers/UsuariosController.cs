using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.HealthFoot.Models;

namespace Web.HealthFoot.Controllers
{
    public class UsuariosController : Controller
    {

        public ActionResult List()
        {

            UsuarioModelo Usuario = new UsuarioModelo();
            ViewBag.Usuario = Usuario.findAll();
            return View();

        }

        public ActionResult Show(int id)
        {

            UsuarioModelo Usuario = new UsuarioModelo();
            ViewBag.Usuario = Usuario.find(id);
            return View();

        }

        public ActionResult Create()
        {

            RolModelo Rol = new RolModelo();
            ViewBag.Rol = Rol.findAll();
            return View();

        }

        public ActionResult Edit(int id)
        {

            ViewBag.UsuarioId = id;
            UsuarioModelo Usuario = new UsuarioModelo();
            ViewBag.Usuario = Usuario.find(id);
            RolModelo Rol = new RolModelo();
            ViewBag.Rol = Rol.findAll();
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